namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 1;
            char x = 'a';
            double p = 5.5;
            string o = "hello";
            bool b = false;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(o);
            Console.WriteLine(x);
            Console.WriteLine(p);
            Console.WriteLine(b);
            Console.WriteLine(a + p);

            Console.WriteLine(a + " " + x); // int + a
            Console.WriteLine(x + " " + a + " " + p); // a + int + double
            */
            /*Console.WriteLine("Enter first numbee:");   // Q2
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(b - a);
            Console.WriteLine(a / b);
            Console.WriteLine(b / a);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(b % a);*/



            // Q 3: to swap strings and intgers
            // Part A (intger)
            int a = 5;
            int b = 3;
            int b1 = 0; int a1 = 0;
            b1 = a;
            a1 = b;
            //(a, b) = (b, a);
            Console.WriteLine("a = " + a1);
            Console.WriteLine("b = "+ b1);
            //Console.WriteLine
            // Part B (string)
            string h = "Hello";
            string w = "World";
            string c = ""; string d = "";

            //(h,w) = (w,h);
            c = w;
            d = h;
            //(a, b) = (b, a);
            Console.WriteLine("h = " + c);
            Console.WriteLine("w = " + d);
            //Console.WriteLine(h);
            //Console.WriteLine(w);



        }
    }
}