using System;

namespace _26._10._23
{
    public class _8_4_CheckClass : IFormattable
    {
        public string Data { get; set; }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            _8_4_CheckClass o = new _8_4_CheckClass();
            if (o is IFormattable)
            {
                return Data;
            }
            else
            {
                return ToString();
            }
        }

    }
}
