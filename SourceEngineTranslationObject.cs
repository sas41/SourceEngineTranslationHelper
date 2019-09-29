namespace SourceEngineTranslationHelper
{
    class SourceEngineTranslationObject
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }

        public SourceEngineTranslationObject(string key, string value, string comment = "")
        {
            Key = key;
            Value = value;
            Comment = comment;
        }

        public override string ToString()
        {
            // Comment Only Line
            if (Key == "" && Value == "" && Comment != "")
            {
                return $"//{Comment}";
            }
            else if (Key == "" && Value == "" && Comment == "")
            {
                return "";
            }
            else if ((Key != "" || Value != "") && Comment == "")
            {
                return $"\"{Key}\"\t\"{Value}\"";
            }
            else
            {
                return $"\"{Key}\"\t\"{Value}\"\t//{Comment}";
            }
        }
    }
}
