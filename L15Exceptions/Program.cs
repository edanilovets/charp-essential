using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("My exception");
            exception.HelpLink = "https://mycompany.com/ErrorService";
            exception.Data.Add("Exception cause", "My test excpetion");
            exception.Data.Add("Exception time", DateTime.Now);
            try
            {
                //int a = 2;
                //int b = a / 0;
                throw exception;
            }
            catch(Exception e)
            {
                Console.WriteLine("Target:              {0}", e.TargetSite);
                Console.WriteLine("Target class:        {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Target type:         {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message:             {0}", e.Message);
                Console.WriteLine("Source:              {0}", e.Source);
                Console.WriteLine("Help link:           {0}", e.HelpLink);
                Console.WriteLine("Stacktrace:          {0}", e.StackTrace);
                foreach(DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("{0}: {1}", de.Key, de.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
