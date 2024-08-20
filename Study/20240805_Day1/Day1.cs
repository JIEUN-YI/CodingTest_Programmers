namespace _20240718_Day1
{
    public class Day1
    {
        /// <summary>
        /// Day1 - 두 수의 합을 구하는 코딩테스트
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120802
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        /// <summary>
        /// Day1 - 두 수의 차를 구하는 코딩테스트
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120803
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        /// <summary>
        /// Day1 - 두 수의 곱을 구하는 코딩테스트
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120804
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Multiplu(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        /// <summary>
        /// Day1 - 두 수의 나눗셈의 몫을 구하는 코딩테스트
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120805
        /// < 풀이 주의 사항 >
        /// 나눗셈의 몫을 구하는 연산자 : /
        /// 나눗셈의 나머지를 구하는 연산자 : %
        /// 두 개를 헷갈리지 않도록 주의할 것
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
