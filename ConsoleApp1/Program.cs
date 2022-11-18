using System;
    class Project
    {
        public static void Main()
        {
            string e = Console.ReadLine();
            string f = Console.ReadLine();
            string g = Console.ReadLine();
            int a = Convert.ToInt32(e);
            int b = Convert.ToInt32(f);
            int c = Convert.ToInt32(g);
            if (a + b > c && a + c > b && b + c > a)
             mohit(a,b,c);
            else
               Console.WriteLine("NO");
            Console.ReadKey();
        }
    
    private static void mohit (int x , int y , int z )
     {
        int w = x * y * z;
        Console.WriteLine(w);
     }
    
    }//برنامه ای بنویسید ک سه عدد را خوانده و تشکیل یک مثلث دهند و محیط انرا چاپ کند

