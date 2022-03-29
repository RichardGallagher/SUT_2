using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_2
{
    public 
        class SUT
    {
        static void Main(string[] args)
        {
           
        }
        public bool CheckAge(int age)
        {
          //  throw new System.NotImplementedException("Not coded yet");

            if (age >= 18 && age <= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         
        public double GetCost(string pCode)
        {
                //throw new System.NotImplementedException("no coded yet");
                double cost;
                switch (pCode)
                {
                    case "ABC":
                        cost = 10.10;
                        break;
                    case "XYZ":
                        cost = 69.34;
                        break;
                    case "FR45":
                        cost = 34;
                        break;
                    case "S34":
                    case "G65":
                    case "F34":
                        cost = 5;
                        break;
                    default:
                        cost = -999;
                        break;
                }
                return cost;



        }

        public void AllTheNines(int[] number)
        {
           // int[] numbers;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = 9;
            }  
        }

        public int passCounter(int[] number)
        {
            int counter = 0;
            // int[] numbers;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 40)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
   
}

