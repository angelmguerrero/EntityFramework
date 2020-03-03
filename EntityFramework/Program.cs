using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TestEntities ctx = new TestEntities())
            {


                foreach (var result in ctx.SP_RASTREABILIDADMATRIZ("11CC699D7AA34B1ABA3A0F0879B9F327", "11CC699D7AA34B1ABA3A0F0879B9F327"))
                {
                    Console.WriteLine(result.SEMANA);
                }

                Console.WriteLine();
                Console.ReadLine();


            }
        }
    }
}
