using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(",", TwoSum(nums, target)));

           
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var array = new List<int>();
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        array.Add(i);
                        array.Add(j);
                        found = true;
                        break;
                    }
                }
                if (found == true)
                    break;
            }

            return array.ToArray();
        }
    }
}
