namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            int reversedNum = x.Reverse();
            Console.WriteLine("returned reversed int : " + reversedNum);

            //----------------------------------------

            int y = 4531;
            int numberOfDigits = y.NumberOfDigits();
            Console.WriteLine($"number of digits : {numberOfDigits}");

            //----------------------------------------

            string name = "    Omar ";

            string trimmedString = name.Trim();

            Console.WriteLine($"The trimmed string is : {trimmedString}");

            //----------------------------------------

            int[] nums = new int[] {1,2,5,9,4,54,12 };

            int maxNum = nums.GetMaxInt();

            Console.WriteLine(maxNum);

            //----------------------------------------

        }
    }
}
