using System;
using System.Collections.Generic;
using System.Text;

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


        public string Export()
        {
            StringBuilder objects = new StringBuilder();
            foreach (var item in Pairs)
            {
                objects.Append($"{indent}{indent}{item}{nl}");
            }
            string template = $"\"lang\"{nl}{{{nl}{indent}\"Language\" \"{Language}\"{nl}{indent}\"Tokens\"{nl}{indent}{{{nl}{objects.ToString()}{indent}}}{nl}}}";
            return template;
        }

    }
}
