using System.Text;

namespace Practise_project
{
    public class Fibonacci_number
    {
        long[]nums;
        int countOfNums;
        public Fibonacci_number(int count)
        {
            countOfNums = count;
            nums = new long[countOfNums];
            nums[0] = 0;
            nums[1] = 1;
        }
        public void calc()
        {
            for (int i = 2; i < countOfNums; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < countOfNums; i++)
            {
                sb.Append(nums[i]).Append(' ');
            }

            return sb.ToString();
        }
    }
}