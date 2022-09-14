using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhStringDemos
{
    internal class Application
    {

        public void Run()
        {









            //STRING 1

            string userString;
            string myString = "";


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Mata in en sträng: ");
                userString = Console.ReadLine();
                myString += userString + " ";

            }

            Console.WriteLine(myString);

        }


    }
}
