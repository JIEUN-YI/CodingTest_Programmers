namespace _20240805_Day2
{
    public class Program
    {
        /// <summary>
        /// 제목 : 두 수의 나눗셈
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120806
        /// 문제 : 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수
        ///        부분을 return 하도록 soltuion 함수를 완성해주세요.
        /// 예시 : ( 3, 2 ) => 1500 / ( 7, 3 ) => 2333 / (1, 16) => 62
        /// </summary>
        public static int TwoDivision(int num1, int num2)
        {
            double result;
            result = (double)num1 / (double)num2 *1000;
            return (int)result;
        }

        /// <summary>
        /// 제목 : 숫자 비교하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
        /// 문제 : 정수 num1과 num2가 매개변수로 주어집니다. 
        ///        두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
        /// 예시 : (2, 3) => -1 / (11, 11) => 1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static int CompareNum(int num1, int num2)
        {
            if(num1 == num2)
            {
                return 1;
            } 
            else
            {
                return -1;
            } 
        }

        /// <summary>
        /// 제목 : 분수의 덧셈
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120808
        /// 문제 : 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 
        ///        두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다. 
        ///        두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 
        ///        solution 함수를 완성해보세요.
        /// 예시 : numer1 = 1 / denom1 = 2 / numer2 = 3 / denom2 = 4 => [5, 4]
        ///        numer1 = 9 / denom1 = 2 / numer2 = 1 / denom2 = 3 => [29, 6]
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void FountainAdd(int number1, int denom1, int number2, int denom2)
        {
            int[] fountainArray = new int[2];
            for(int i = 1; ; i++)
            {
                
            }
           
        }


        static void Main(string[] args)
        {
            FountainAdd(1, 2, 3, 4);
        }
    }
}
