using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    public class Parser
    {

        public string ParseDecimalString(string input)
        {
            int tmp = 0;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                Int32.TryParse(input.Substring(i, 2), out tmp);
                result.Append((char)tmp);
            }
            return result.ToString();
        }

        public string ParseHexString(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                long tmp = int.Parse(input.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                result.Append((char)tmp);
            }
            return result.ToString();

        }
    }
}
