using System;
using System.Collections.Generic;


namespace ChJson
{
    [Serializable]
    public class JsonArray : JsonBaseType
    {
        public const char START_CHAR = '[';
        public const char END_CHAR = ']';
        public const char CUT_CHAR = ',';

        public void Set(JsonBaseType _obj,int _index)
        {
            if (!IsInArrayRangeNum(_index)) return;
            if (_obj == null) _obj = new JsonNull();

            arrayVal[_index] = _obj;
        }

        public JsonBaseType GetObj(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return null;

            return arrayVal[_index];
        }


        public bool GetBool(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return false;

            var flg = (JsonBoolean)arrayVal[_index];
            if (flg == null) return false;

            return flg.Get();
        }

        public string GetString(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return "";

            var str = (JsonString)arrayVal[_index];
            if (str == null) return "";

            return str.Get();
        }

        public double GetNumberDouble(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return 0.0;

            var num = (JsonNumber)arrayVal[_index];
            if (num == null) return 0.0;

            return num.GetDouble();
        }

        public int GetNumberInt(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return 0;

            var num = (JsonNumber)arrayVal[_index];
            if (num == null) return 0;

            return num.GetInt();
        }

        public JsonObject GetObject(int _index)
        {
            if (!IsInArrayRangeNum(_index)) return null;

            return (JsonObject)arrayVal[_index];
        }

        public void Add(JsonBaseType _obj)
        {
            if(_obj == null)_obj = new JsonNull();
            arrayVal.Add(_obj);
        }

        public void Add(string _str)
        {
            var str = new JsonString();
            str.Set(_str);
            arrayVal.Add(str);
        }

        public void Add(double _num)
        {
            var num = new JsonNumber();
            num.Set(_num);
            arrayVal.Add(num);
        }

        public void Add(bool _flg)
        {
            var flg = new JsonBoolean();
            flg.Set(_flg);
            arrayVal.Add(flg);
        }

        public override bool SetRawData(string _text)
        {
            if (_text.Length < 2) return false;
            if (_text[0] != START_CHAR || _text[_text.Length - 1] != END_CHAR) return false;
            string text = _text.Substring(1, _text.Length - 2);
            List<string> textList;
            if(!GetCutTextList(out textList, _text))return false;

            for (int i = 0; i < textList.Count; i++)
            {
                var obj = Create(textList[i]);
                Add(obj);
            }

            return true;
        }

        public override string GetRawData()
        {
            string res = "";

            res += START_CHAR;

            for(int i =  0;i< arrayVal.Count;i++)
            {
                res += arrayVal[i].GetRawData();
                if (i < arrayVal.Count - 1)
                    res += CUT_CHAR;
            }

            res += END_CHAR;

            return res;
        }

        private bool IsInArrayRangeNum(int _index)
        {
            return arrayVal.Count > _index && 0 >= _index;
        }

        List<JsonBaseType>arrayVal = new List<JsonBaseType>();
    }

}
