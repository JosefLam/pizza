using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> {
                "Pepperoni", "margherita","Ham and Pineapple"
            };

            string selection = ChooseFrom(options);
        }

        private static string ChooseFrom(List<string> options)
        {
            //give options
            bool valid = false;
            while (!valid)
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[i]}");
                    Console.Write($"Choose a number (1-{options.Count}");
                    string response = Console.ReadLine();
                    int chosenposition = -1;
                    if (int.TryParse(response, out chosenposition) &&
                        chosenposition > 0 &&
                        chosenposition <= options.Count)
                    {
                        valid = true;
                        return options[chosenposition - 1];
                    }

                    return options[chosenposition - 1];
                }

            //repeat until valid input

           
            
        }
    }
}
