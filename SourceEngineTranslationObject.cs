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
            string ret = $"\"{Key}\"\t\"{Value}\"";

            if (Comment != "")
            {
                ret = ret + $"\t//{Comment}";
            }

            return ret;
        }
    }
}
