using System;
using System.Collections.Generic;

namespace ChJson
{
    [Serializable]
    public class JsonObject : JsonBaseType
    {
        public const char START_CHAR = '{';
        public const char END_CHAR = '}';
        public const char CUT_CHAR = ',';
        public const char KEY_VALUE_CUT_CHAR = ':';

        public override bool SetRawData(string _text)
        {
            if (_text.Length < 2) return false;
            if (_text[0] != START_CHAR || _text[_text.Length - 1] != END_CHAR) return false;
            string text = _text.Substring(1, _text.Length - 2);
            List<string> textList;
            if (!GetCutTextList(out textList, text)) return false;

            bool successFlg = true;

            for(int i = 0;i < textList.Count;i++)
            {
                var keyValue = CutKeyValue(textList[i]);
                if (keyValue == null) continue;

                var key = new JsonString();
                if(!key.SetRawData(keyValue.key))
                {
                    successFlg = false;
                    break;
                }

                var obj = Create(keyValue.value);
                if (obj ==  null)
                {
                    successFlg = false;
                    break;
                }

                values[key] = obj;
            }


            return successFlg;
        }

        public override string GetRawData()
        {
            string res = "";

            int count = 0;

            foreach (var keyValues in values)
            {
                res += keyValues.Key.GetRawData();
                res += KEY_VALUE_CUT_CHAR;
                res += keyValues.Value.GetRawData();
                if (count < values.Count - 1)
                    res += CUT_CHAR;

                count++;
            }

            return res;
        }

        class keyValue
        {
            public string key = "";
            public string value = "";
        }

        keyValue CutKeyValue(string _val)
        {
            bool inString = false;

            for(int i= 0;i<_val.Length;i++)
            {
                if (_val[i] == JsonString.START_END) inString = !inString;

                if (inString) continue;

                if (_val[i] != KEY_VALUE_CUT_CHAR) continue;

                keyValue res = new keyValue();

                res.key = _val.Substring(0, i);
                res.value = _val.Substring(i + 1);

                return res;

            }

            return null;
        }

        Dictionary<JsonString,JsonBaseType>values = new Dictionary<JsonString,JsonBaseType>();
    }

}