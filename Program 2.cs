using System;
    class Project
    {
        public static void Main(string[] args)
        {
        string d = Console.ReadLine();
        string e = Console.ReadLine();
        string f = Console.ReadLine();
        int a = Convert.ToInt32(d);
        int b = Convert.ToInt32(e);
        int c = Convert.ToInt32(f);
        int g = vol(a, b, c);
        Console.WriteLine(g);
        Console.ReadKey();
        }
    private static int vol(int x , int y , int z)
    {
        int w = x * y * z;
        return w;

    }
    }//برنامه ای بنویسید ک اطلاعات طول و عرض و ارتفاع را خوانده و حجم مکعب را چاپ کند
