using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PART6_NULLABLE_TYPES_IN_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? AreYouMajor = null;

            if(AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (!AreYouMajor.Value)
            {
                Console.WriteLine("User is not Major");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }
        }
    }
}
