using System;

namespace ChJson
{
    [Serializable]
    public class JsonNumber : JsonBaseType
    {
        static public bool operator ==(JsonNumber _val, double _num)
        {
            return _num == _val.val;
        }
        static public bool operator !=(JsonNumber _val, double _num)
        {
            return _num != _val.val;
        }

        public override bool Equals(object obj)
        {
            return val.Equals(obj);
        }

        public override int GetHashCode()
        {
            return val.GetHashCode();
        }

        public void Set(double _val) { val = _val; }

        public double GetDouble() { return val; }

        public int GetInt() { return (int)val; }

        public override bool SetRawData(string _text)
        {
            if (!double.TryParse(_text, out val)) return false;
            return true;
        }

        public override string GetRawData()
        {
            return val.ToString();
        }

        double val = 0.0f;
    }

}