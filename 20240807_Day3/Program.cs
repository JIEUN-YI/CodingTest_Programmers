using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace _20240807_Day3
{
    public class Program
    {
        /// <summary>
        /// 제목 : 나머지 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120810
        /// 문제 : 정수 num1, num2가 매개변수로 주어질 때, 
        ///        num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 3, 2 ) => 1 / ( 10, 5 ) => 0
        /// </summary>
        public static int FindRest(int num1, int num2)
        {
            int result = num1 % num2; //나머지 값을 구하는 연산자 %
            return result;
            // 나머지의 몫을 구하는 연산자 / 와 착각 주의
        }

        /// <summary>
        /// 제목 : 중앙값 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
        /// 문제 : 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 
        ///        예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 정수 배열 array가 매개변수로 주어질 때, 
        ///        중앙값을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 1, 2, 7, 10, 11 ] => 7 / [ 9, -1, 0 ] => 0
        /// </summary>
        public static int FindMiddle(int[] array)
        {
            Array.Sort(array); //정렬을 오름차순으로 정렬하는 함수 사용
            int result;
            result = array[array.Length / 2]; // 정렬의 길이의 중앙값에 해당하는 배열의 값을 저장
            return result;

        }

        /// <summary>
        /// 제목 : 최빈값 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120812
        /// 문제 : 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다. 
        ///        정수 배열 array가 매개변수로 주어질 때, 최빈값을 return 하도록 solution 함수를 완성해보세요. 
        ///        최빈값이 여러 개면 -1을 return 합니다.
        /// 예시 : [ 1, 2, 3, 3, 3, 4 ] => 3 / [ 1, 1, 2, 2 ] => -1 / [ 1 ] => 1
        /// </summary>
        struct CountNum
        {
            public static int num;
            public static int count;
        }

        public static void FindFrequency(int[] array)
        {
            Array.Sort(array);//주어진 배열을 정렬
            List<CountNum> list = new List<CountNum>(); //정렬한 배열의 숫자와 개수를 정리할 리스트 제작
            int count = 1;
            // 배열의 전부를 탐색하면서
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i-1] == array[i]) // 배열의 두 값이 같으면 카운트
                {
                    count++;
                }
                else if (array[i - 1] != array[i]) // 배열의 두 값이 다르면 이전 값 까지의 카운트와 값을 리스트에 저장
                {
                    CountNum.num = array[i-1];
                    CountNum.count = count;
                    Console.WriteLine($"{CountNum.num} | {CountNum.count}"); // 확인용 출력
                    list.Add(new CountNum());// 리스트에 저장
                    count = 1; // 카운트를 1로 변경
                }  
            }
            CountNum.num = array.Last(); // 배열의 마지막 값을 저장
            CountNum.count = count; // 배열의 마지막 값의 카운트를 저장
            Console.WriteLine($"{CountNum.num} | {CountNum.count}"); // 확인용 출력
            list.Add(new CountNum());

            
        }

        /// <summary>
        /// 제목 : 짝수는 싫어요
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120813
        /// 문제 : 정수 n이 매개변수로 주어질 때, 
        ///        n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 10 ) => [ 1, 3, 5, 7, 9 ] / ( 15 ) => [ 1, 3, 5, 7, 9, 11, 13, 15 ] 
        /// </summary>


        static void Main(string[] args)
        {
            int[] array = { 7, 7, 6, 1, 1, 5, 5, 6, 1, 1 };
            FindFrequency(array);
        }
    }
}


