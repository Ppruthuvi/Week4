using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1");
            question1();
            Console.WriteLine(" ");

            Console.WriteLine("Q2");
            Console.WriteLine(question2());
            Console.WriteLine(" ");

            Console.WriteLine("Q3a");
            question3a();
            Console.WriteLine(" ");

            Console.WriteLine("Q3");
            question3();
            Console.WriteLine(" ");

            Console.WriteLine("Q4");
            Console.WriteLine(question4("kkkktttrrrrrrrrrr"));
            Console.WriteLine(question4("p555ppp7www"));
            Console.WriteLine(" ");

            Console.WriteLine("Q5");
            Console.WriteLine(" ");

            Console.WriteLine("Q6");
            question6();
            Console.WriteLine(" ");

            Console.WriteLine("Q7");
            question7();
            Console.WriteLine(" ");

            Console.WriteLine("Q8");
            Console.WriteLine(question8("My name is Pruthuvi"));
            Console.WriteLine(" ");

            Console.WriteLine("Q9");
            Person A = new Person("A");
            Person B = new Person("B");
            Person C = new Person("C");
            Person[] tab = { A, B, C };
            Console.WriteLine(tab);
        }

        public static void question1()
        {
            string a = "abcd";
            string b = a.Substring(0);
            string c = a.Substring(3);
            string e = a.Substring(1, 2);
            string d = c + e + b[0];
            Console.WriteLine(d);
        }

        public static bool question2()
        {
            int[] input = { 5, 3, 4, 8, 9 };
            int[] check = { 3, 4, 5 };
            for (var i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == check[0] && input[i + 1] == check[1] && input[i + 2] == check[2])
                    return true;
            }
            return false;
        }

        public static void question3a()
        {
            char example = 'a';
            Console.WriteLine("Code ASCII with : " + Convert.ToInt32(example));
        }

        public static void question3()
        {
            string a = "abcde";
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }

        public static string question4(string str)
        {
            var count = 0;
            var last = str[0];
            var newStr = string.Empty;

            foreach (var s in str)
            {
                if (s == last)
                {
                    count++;
                }
                else
                {
                    newStr += last.ToString() + count;
                    last = s;
                    count = 1;
                }
            }

            newStr += last.ToString() + count;

            return newStr;
        }

        public static void question6()
        {
            int zero = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            int nine = 0;
            int[] input = { 5, 7, 5, 2, 2, 4, 5 };
            for (int j = 0; j <= input.Length - 1; j++)
            {
                if (input[j] == 0) { zero = zero + 1; }
                if (input[j] == 1) { one = one + 1; }
                if (input[j] == 2) { two = two + 1; }
                if (input[j] == 3) { three = three + 1; }
                if (input[j] == 4) { four = four + 1; }
                if (input[j] == 5) { five = five + 1; }
                if (input[j] == 6) { six = six + 1; }
                if (input[j] == 7) { seven = seven + 1; }
                if (input[j] == 8) { eight = eight + 1; }
                if (input[j] == 9) { nine = nine + 1; }
            }
            Console.WriteLine("0 is " + zero + "times");
            Console.WriteLine("1 is " + one + "times");
            Console.WriteLine("2 is " + two + "times");
            Console.WriteLine("3 is " + three + "times");
            Console.WriteLine("4 is " + four + "times");
            Console.WriteLine("5 is " + five + "times");
            Console.WriteLine("6 is " + six + "times");
            Console.WriteLine("7 is " + seven + "times");
            Console.WriteLine("8 is " + eight + "times");
            Console.WriteLine("9 is " + nine + "times");
        }

        public static void question7()
        {
            int n = 4;
            int m = 4;
            int c = 1;
            for (int i = 0; i <= n; i++)
            {
                c = c * n;
                n = n - 1;
            }
            Console.WriteLine(m + "! = " + c);
        }


        public static int question8(string str)
        {
            int nbspace = 0;
            string space = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (space == str.Substring(i, 1))
                    nbspace++;
            }
            return nbspace;
        }

    }
}
