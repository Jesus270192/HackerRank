using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy {
  public  class EasyExercise  {

        /// <summary>
        /// https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true
        /// </summary>
        public void staircase() {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= n; i++) {
                for (int spaces = 0; spaces < n - i; spaces++) {
                    Console.Write(" ");
                }

                for (int ast = 1; ast <= i; ast++) {
                    Console.Write("#");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true
        /// </summary>
        public void miniMaxSum() {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            long min, max,value;

            value = min = max = 0;

            for (int i = 0; i < arr.Count; i++) {
                value = 0;

                for (int j = 0; j < arr.Count; j++) {
                    if (j!=i) {
                        value += arr[j];
                    }
                }

                if (i==0) {
                    min = max = value;
                }

                if (value<min) {
                    min = value;
                }else if(value>max){
                    max = value;
                }
            }

            Console.Write(min + " " + max);
        }
    }
}
