#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void DoWork()
        {
            

            Date weddingAnniversary = new Date(2015, Month.July, 4);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");
        }

        static void Main()
        {
            try
            {
                DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
