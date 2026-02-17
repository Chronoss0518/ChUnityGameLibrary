
using System;

namespace ChJson
{
    [Serializable]
    public class JsonBoolean : JsonBaseType
    {
        const string TRUE = "true";
        const string FALSE = "false";

        static public bool operator ==(JsonBoolean _val, bool _flg)
        {
            return _flg == _val.flg;
        }
        static public bool operator !=(JsonBoolean _val, bool _flg)
        {
            return _flg != _val.flg;
        }

        public override bool Equals(object obj)
        {
            return flg.Equals(obj);
        }

        public override int GetHashCode()
        {
            return flg.GetHashCode();
        }

        public void Set(bool _flg) { flg  = _flg; }
        
        public bool Get() { return flg; }

        public override bool SetRawData(string _text)
        {
            if (TRUE != _text &&FALSE !=_text) return false;
            flg = TRUE ==_text;
            return true;
        }

        public override string GetRawData()
        {
            return flg ? TRUE : FALSE;
        }

        bool flg = false;
    }

}