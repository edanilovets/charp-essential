using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7GoodStructureDesign
{
    class Program
    {
        //Example of good structure design
        struct ZipCode
        {
            //Fields
            int fiveDigitCode;
            int plusFourExtension;

            //Constructors
            public ZipCode(int fiveDigitCode, int plusFourExtension)
            {
                this.fiveDigitCode = fiveDigitCode;
                this.plusFourExtension = plusFourExtension;
            }

            public ZipCode(int fiveDigitCode) : this(fiveDigitCode, 0)
            {
            }

            //Properties
            public int FiveDigitCode
            {
                get { return fiveDigitCode; }
            }

            public int PlusFourExtension
            {
                get { return plusFourExtension; }
            }
        }
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode(12345, 1234);
            //zipCode.FiveDigitCode = 12345;
            //zipCode.PlusFourExtension = 1234;
            Console.WriteLine(zipCode.FiveDigitCode + "-" + zipCode.PlusFourExtension);
            Console.ReadKey();
        }
    }
}
