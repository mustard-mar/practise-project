
using System.Text;

namespace Practise_project
{
    public class BigIntForPi
    {
        int[] nums;
        int a = 355;
        int b = 113;
        long count;

        public BigIntForPi(uint count)
        {
            this.count = count;
            nums = new int[count + 2];
        
        }
        public void divide()//число пи считается без использованиясложных формул
        {
            for (int i = 0; i < count +2; i++)
            {
                int numMultipl = 0;
                while (numMultipl * b <= a)
                {
                    numMultipl++;
                }
                numMultipl--;
                a = (int)(a - (b * numMultipl));
                nums[i] = numMultipl;
                if (i == 0)
                {
                    i++;
                    nums[i] = (int)',';
                }
                a *= 10;
            }
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count+2; i++)
            {
                if (i==1)
                {
                    sb.Append((char)nums[i]);
                }
                else sb.Append(nums[i]);
            }
            return sb.ToString();
        }


    }
}
