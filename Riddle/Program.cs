using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riddle
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "86111105991011081011151153210511632991141051011154432871051101031081011151153210210811711611610111411544328411111111610410810111511532981051161011154432771111171161041081011151153210911711611610111411546";
            string string2 = "5468652073756d2074686520746f74616c206f66207468652061736369692076616c7565732066726f6d2065616368206c657474657220696e2074686520616e7377657220746f2074686520726964646c652e";
            string string3 = "507473543466548535531534555466536545548466531466546538545544535466549533548535535544467";
            Parser parser = new Parser();
            Console.WriteLine($"Hex Decoded Value for the String: [ {string1} ] is \n\n {parser.ParseHexString(string1)} \n\n *****");
            Console.WriteLine($"Dec Decoded Value for the String: [ {string1} ] is \n\n {parser.ParseDecimalString(string1)} \n\n *****");
            Console.WriteLine($"Decoded Value for the String: [ {string2} ] is  \n\n  {parser.ParseHexString(string2)} \n\n *****");
            Console.WriteLine($"Hex Decoded Value for the String: [ {string3} ] is  \n\n  {parser.ParseHexString(string3)} \n\n ***** ");
            Console.WriteLine($"Dec Decoded Value for the String: [ {string3} ] is \n\n {parser.ParseDecimalString(string1)} \n\n *****");
            Console.ReadLine();
        }
    }
}
