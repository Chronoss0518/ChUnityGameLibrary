
using System;
using System.Collections.Generic;

namespace ChJson
{
    [Serializable]
    public abstract class JsonBaseType
    {
        public static JsonBaseType Create(string _text)
        {
            JsonBaseType res = new JsonNull();
            if (res.SetRawData(_text)) return res;
            res = new JsonBoolean();
            if (res.SetRawData(_text)) return res;
            res = new JsonNumber();
            if (res.SetRawData(_text)) return res;

            return null;
        }

        public abstract bool SetRawData(string _text);

        public abstract string GetRawData();

        protected string RemoveBlanks(string _text)
        {
            string res = "";

            bool inString = false;
            //bool inArray = false;
            //bool inObject = false;

            for(int i = 0;i< _text.Length;i++)
            {
                if(inString)
                {
                    if (_text[i] <= 0x20) continue;
                }

                if (_text[i] == JsonString.START_END)
                {
                    inString = !inString;
                }

                res += _text[i];
            }


            return res;
        }
        protected bool GetCutTextList(out List<string> _res,string _text)
        {
            _res = new List<string>();

            string tmp = "";

            bool inString = false;
            int inArray = 0;
            int inObject = 0;

            for (int i = 0; i< _text.Length; i++)
            {
                if (!inString && inArray <= 0 && inObject <= 0)
                {
                    if (_text[i] <= 0x20) continue;
                }

                tmp += _text[i];

                if (_text[i] == JsonString.START_END)
                {
                    if(inString)
                    {
                        _res.Add(tmp);
                        tmp = "";
                    }
                    inString = !inString;
                }

                if (inString) continue;


                if (_text[i] == JsonArray.START_CHAR)
                {
                    inArray++;
                }

                if (_text[i] == JsonArray.END_CHAR)
                {
                    inArray--;
                    if(inArray <= 0 && inObject<=0)
                    {
                        _res.Add(tmp);
                        tmp = "";
                    }
                }

                if (_text[i] == JsonObject.START_CHAR)
                {
                    inObject++;
                }

                if (_text[i] == JsonObject.END_CHAR)
                {
                    inObject--;
                    if (inArray <= 0 && inObject<=0)
                    {
                        _res.Add(tmp);
                        tmp = "";
                    }
                }

                if (inArray > 0 || inObject > 0) continue;

                if (_text[i] == JsonArray.CUT_CHAR || _text[i] == JsonObject.CUT_CHAR)
                {
                    tmp.Remove(tmp.Length - 1);
                    _res.Add(tmp);
                    tmp = "";
                }
            }

            return true;

        }

    }
    
    [Serializable]
    public class JsonNull : JsonBaseType
    {
        public const string text = "null";

        public override bool SetRawData(string _text)
        {
            if (_text != text) return false;
            return true;
        }

        public override string GetRawData()
        {
            return text;
        }
    }
}