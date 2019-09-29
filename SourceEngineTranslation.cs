using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace SourceEngineTranslationHelper
{
    [Serializable]
    class SourceEngineTranslation
    {
        const string indent = "\t";
        const string nl = "\r\n";

        public string Project { get; set; }
        public string Language { get; set; }

        public List<SourceEngineTranslationObject> Pairs { get; set; }

        public SourceEngineTranslation() : this("Untitled", "English")
        {
        }

        public SourceEngineTranslation(string project, string lang)
        {
            Project = project;
            Language = lang;
            Pairs = new List<SourceEngineTranslationObject>();
        }

        public SourceEngineTranslation(string txt)
        {
        }

        public string Export()
        {
            StringBuilder objects = new StringBuilder();
            foreach (var item in Pairs)
            {
                objects.Append($"{indent}{indent}{item}{nl}");
            }
            // Behold! The template string of shame! Cower before it's agonizing ugliness!
            string template = $"\"lang\"{nl}{{{nl}{indent}\"Language\" \"{Language}\"{nl}{indent}\"Tokens\"{nl}{indent}{{{nl}{objects.ToString()}{indent}}}{nl}}}";
            return template;
        }

        public void Parse(string txt)
        {
            try
            {
                /*
                    Behold! Behold Mortal!
                    The Regex of DOOM!
                    This regex string matches:
                        -Everything between two double-quotation marks, while including escaped double-quotes
                        -Every comment, starting with //
                        -Every opening and closing curly-bois.
                    Here is the break down of it:

                    Capture Type 1
                        (?<=(?<!\\)"")  - This bit looks for a quotation mark, that is not escaped (\") before the middle bit.
                        (.*?)           - This is the middle bit, it captures everything...
                        (?=(?<!\\)"")   - This bit looks for a quotation mark, that is not escaped (\") after the middle bit.
                    Capture Type 2
                        ((?<=//)(.*))   - This bit captures everything after a (//), these are comments.
                    Capture Type 3 and 4
                        (\{) and (\})   - These capture opening and closing curly-bois.

                    Each capture type is seperated by a "|" for a logical OR.
                    The whole thing is in (), to represent one big filter for each line.

                */
                string qPattern = @"((?<=(?<!\\)"")(.*?)(?=(?<!\\)"")|((?<=//)(.*))|(\{)|(\}))";
                List<string> lines = txt.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                string lang = "";
                List<SourceEngineTranslationObject> pairs = new List<SourceEngineTranslationObject>();

                List<string> line;
                Match match;

                int maxGroups = 6;
                int groups = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    match = Regex.Match(lines[i], qPattern);
                    line = new List<string>();
                    groups = 0;


                    if (match.Success)
                    {
                        while (groups <= maxGroups)
                        {
                            if (match.Groups[0].Value.Trim() != "")
                            {
                                line.Add(match.Groups[0].Value);
                            }
                            match = match.NextMatch();
                            groups++;
                        }
                    }

                    // Language line
                    if (line.Count > 1 && line[0].ToLower() == "language")
                    {
                        lang = line[1].ToLower();
                    }
                    // Empty line
                    else if (line.Count == 0)
                    {
                        pairs.Add(new SourceEngineTranslationObject("", ""));
                    }
                    // Comment Only line
                    else if (line.Count == 1 && line[0].ToLower() != "lang" && line[0].ToLower() != "tokens" && line[0].ToLower() != "{" && line[0].ToLower() != "}" )
                    {
                        pairs.Add(new SourceEngineTranslationObject("", "", line[0]));
                    }
                    // KVP line
                    else if (line.Count == 2)
                    {
                        pairs.Add(new SourceEngineTranslationObject(line[0], line[1]));
                    }
                    // KVP + Comment line
                    else if (line.Count >= 3)
                    {
                        pairs.Add(new SourceEngineTranslationObject(line[0], line[1], string.Join(" ", line.Skip(2))));
                    }

                }

                Language = lang;
                Pairs = pairs;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
