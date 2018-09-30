using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInterger
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Key-in Roman Number:");
                string s = Console.ReadLine();
                Console.WriteLine(ToInteger(s));
            }
        }
        public static int ToInteger(string s)
        {
            int sum = 0;
            bool previousIsI = false;
            bool previousIsX = false;
            bool previousIsC = false;
            bool wrongWord = false;
            foreach(var romanChar in s)
            {
                switch (romanChar)
                {
                    case 'I':
                        sum++;
                        previousIsI = true;
                        break;
                    case 'V':
                        if (previousIsI)
                        {
                            sum += 3;
                            previousIsI = false;
                        }
                        else
                        {
                            sum += 5;
                        }
                        break;
                    case 'X':
                        if (previousIsI)
                        {
                            sum += 8;
                            previousIsI = false;
                        }
                        else
                        {
                            sum += 10;
                            previousIsX = true;
                        }
                        break;
                    case 'L':
                        if (previousIsX)
                        {
                            sum += 30;
                            previousIsX = false;
                        }
                        else
                        {
                            sum += 50;
                        }
                        break;
                    case 'C':
                        if (previousIsX)
                        {
                            sum += 80;
                            previousIsX = false;
                        }
                        else
                        {
                            sum += 100;
                            previousIsC = true;
                        }
                        break;
                    case 'D':
                        if (previousIsC)
                        {
                            sum += 300;
                            previousIsC = false;
                        }
                        else
                        {
                            sum += 500;
                        }
                        break;
                    case 'M':
                        if (previousIsC)
                        {
                            sum += 800;
                            previousIsC = false;
                        }
                        else
                        {
                            sum += 1000;
                        }
                        break;
                    default:
                        wrongWord = true;
                        break;
                }
            }
            sum = wrongWord == true ? 0 : sum;
            return sum;
        }
    }

}
