using System;
    class Project
    {
       public static void Main(string[] args)
        {
        string a1 = Console.ReadLine();
        string a2 = Console.ReadLine();
        double a = Convert.ToDouble(a1);
        double b = Convert.ToDouble(a2);
        double c = cal(a, b);
        Console.WriteLine(c);
        Console.ReadKey();
    }
        private static double cal (double x , double y)
    {
        double d = (x * 0.35) + (y * 0.65);
        return d;
    }
        
    }//برنامه ای بنویسید ک نمره میانترم و پایانترم را گرفته و نمره نهایی را چاپ کند

