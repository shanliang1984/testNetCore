using System;
using FrameInfoCIGI;

namespace TestCoreDll
{
    class Program
    {
        static void Main(string[] args)
        {
            IGControl myig = new IGControl();

            myig.DatabaseNumber = 5;
            myig.IGMode = 2;
            myig.MinorVersion = 3;
            myig.TimestampValid = 1;
            myig.ByteSwapMagicNumber = 80;
            myig.HostFrameNumber = 101;
            myig.LastIGFrameNumber = 203;
            myig.Timestamp = 99;

            IGControl.Save(myig, "test.xml");

            IGControl readig = IGControl.Load("test.xml");

            Console.WriteLine(readig.ToString());
        }
    }
}
