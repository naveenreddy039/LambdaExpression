using System;

namespace DemoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabinocci fabinoci = new Fabinocci();
            fabinoci.series();
            //printReverse();
            //StringPalindrome();
            //numPalindrome();
            //highNumber();
            //ReverseString();
            ReverseWord();
        }
        //Reverse the number
        public static void printReverse()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num != 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse of a number is:" + reverse);
        }
        //String Palindrome
        public static void StringPalindrome()
        {
            string input = Console.ReadLine();
            string revStr = string.Empty;

            if (input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    revStr += input[i].ToString();
                }
                if (revStr == input)
                {
                    Console.WriteLine("String is Palindrome input={0} and output={1}", input, revStr);
                }
                else
                {
                    Console.WriteLine("string is not a palindrome input={0} and output={1}", input, revStr);
                }
            }
        }
        //number Palindrome
        public static void numPalindrome()
        {
            int n = int.Parse(Console.ReadLine());
            int res, sum = 0;
            Console.WriteLine("Enter the Number: ");
            int temp = n;
            while (n > 0)
            {
                res = n % 10;
                sum = (sum * 10) + res;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }

        }
        //highest number in array
        public static void highNumber()
        {

            int large = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            large = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (large < arr[i])
                    large = arr[i];
            }
            Console.WriteLine("Largest element in array : " + large);

        }
        //reverse the string
        public static void ReverseString()
        {
            string input = Console.ReadLine();
            string revStr = string.Empty;

            if (input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    revStr += input[i].ToString();
                }
                Console.WriteLine(revStr);
            }
        }
        //Reverse Word
        public static void ReverseWord()
        {
            

            string str = Console.ReadLine();

            string[] a = str.Split(' ');

            int k = a.Length - 1;

            int temp = k;

            for (int i = k; temp >= 0; k--)

            {

                Console.Write(a[temp] + "" + ' ');

                --temp;

            }
        }
    }
}
