using System;

namespace Deliverable1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Data declarations 
            double N_fidgetS = 3.5;
            double N_memes = 5;
            string unit = null;
            bool valid = false;
            string input = null;
            double number = 0;
            double output = 0; 


            while (!valid)
            {
                 
                //Ask for the unit of measure//////////
                Console.Write("Please input a measurement type (inch, foot, figet spinners, memes): ");
                input = Console.ReadLine();
                string measurement = input;

                Console.Write("Please input an amount: ");

                number = double.Parse(Console.ReadLine());

                if (measurement == "inch")
                {
                    output = number * N_fidgetS; //works
                    unit = "fidget spinners";
                }
                else if (input == "foot")
                {
                    output = number * N_memes; //Works
                    unit = "memes";
                }
                else if (input == "figet spinners")
                {
                    output = number / N_fidgetS;
                    unit = "inch";
                }
                else if (input == "memes")
                {
                    output = number / N_memes;
                    unit = "foot";
                }

                //Ask for value here //////////////
                Console.WriteLine("Amount is " + output + " " + unit);

                //Ask to continue //////////////
                Console.Write("Wish to do another calculation? (yes or no) ");
                input = Console.ReadLine();

                if (input == "yes")
                {
                //Do nothing; Continue with processing/the loop. 
                                   }
                else if(input != "yes")
                    { 
                //End loop; You win. 
                    valid = true;

                }

            }
        }
    }
}
