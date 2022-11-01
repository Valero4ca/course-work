//using System;
//    namespace ProjectOne
//{
//    class MAinClass
//{
//    public static void Main(string [] args)
//    {

//    Console.WriteLine("Hello Worid!\nHello");
//            Console.ReadKey();
//}
//}
//}


//using System;
//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            int num=10;
//            uint num_1= 10;
//            float f = 1 .234f;
//            bool boolean = false;
//            string name = "George";
//            char n = 'G';


//            Console.WriteLine(num);



//        }
//    }
//}

//using System;


//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            int num, num_1;
//            Console.WriteLine("Enter first name:");
//           num =  Convert.ToInt32 (Console.ReadLine());
//            Console.WriteLine("\nEnter second name:");
//            num_1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("The result is:" + (num + num_1).ToString();
//            Console.ReadKey();

//        }
//    }
//}


//using System;


//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            double num;

//            Console.WriteLine("How old are you:");
//            num = Convert.ToDouble(Console.ReadLine());
//            if (num > 18.2344 && num < 50)
//                Console.WriteLine("You are older than 15.23");
//            else if (num < 10)
//                Console.WriteLine("Under 18");
//            else
//                Console.WriteLine("Else");
//            string name = num = 15 ? "first" : "second";
//            Console.WriteLine(name);
//            Console.ReadKey();
//        }
//    }
//}


//using System;



//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            Random randNum = new Random();
//            int num;
//            num = randNum.Next(1, 6);
//            switch (num) {
//                case 1:
//                    Console.WriteLine("Num is-" + num);
//                    break;
//                case 2:
//                    Console.WriteLine("Num is equal to" + num);
//                    break;
//                    default;
//                    Console.WriteLine("Nothing" + num);
//                    break;
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;



//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            for (int i = 10; i >= 5; i--)
//            {
//                if (i < 8)
//                    break;
//                Console.WriteLine(i + "\n");


//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Globalization;

//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            int[,] numbers = new int[5, 5];
//            numbers[1, 2] = 23;
//            Console.WriteLine(numbers[]);
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Globalization;

//namespace ProjectOne
//{
//    class MAinClass
//    {
//        public static void Main(string[] args)
//        {
//            float[] numbers = (1.23f, 1.45f, 23.57f);
//            {
//                foreach[float el in numbers]{
//                    Console.WriteLine(el);

//                }

//                Console.ReadKey();
//            }
//        }
//    } 
//}



using System;



namespace ProjectOne
{
    class MAinClass
    {
        public static void Main(string[] args)
        {
            WriteHello("Hi!");
            int num = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int result = Multiply(num, num_2);
            Console.WriteLine("Result is" + result);
            Console.ReadKey();
        }
        public static void WriteHello(string str)
        {
            Console.WriteLine(str);

        }
        public static int Multiply(int num_1, int num_2)
        {
            return num_1 * num_2;

        }
    }
}
