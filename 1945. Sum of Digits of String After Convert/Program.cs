namespace _1945._Sum_of_Digits_of_String_After_Convert;

class Solution
{
    static void Main(string[] args)
    {
        Solution s = new();
        System.Console.WriteLine(s.GetLucky("iiii",1));
        System.Console.WriteLine(s.GetLucky("leetcode",2));
        System.Console.WriteLine(s.GetLucky("zbax",2));
    }

    public int GetLucky(string s, int k)
    {
        int sum = 0;
        foreach (char c in s)
        {
            int number = c - 'a' + 1;
            sum += SumOfDigits(number);
        }
        
        for (int i = 1; i < k; i++)
        {
            sum = SumOfDigits(sum);
        }
    
        return sum;
    }

    public int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
