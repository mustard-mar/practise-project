using System;

namespace Practise_project
{
    public class PrimeDividers
    {
        protected int number;
        public PrimeDividers(int number)
        {
            this.number = number;
        }
        public void calc()
        {
            int a = number;
            int i = 2;
            int count = 0;
            while (a>=i)
            {
                if (IsPrime(i))
                {

                    if (a % i == 0)
                    {
                        a = a / i;
                        count++;
                    }
                    else { if(count!=0)Console.Write(""+i+"^"+count+" ");
                        i++; count = 0; }
                    if(a==1) Console.Write("" + i + "^" + count + " ");

                }
                else { i++; count = 0; }
            }

        }

        private bool IsPrime(int num)
        {
            for (long i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) 
                    return false;
            return true;
        }
    }
}