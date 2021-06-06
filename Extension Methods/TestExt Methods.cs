using System;


namespace Extension_methods
{
    class TestExt_Methods
    {
      static void Main()
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3(10);

            int i = 5;
            long result = i.Factorial();
            Console.WriteLine("Factorial of {0} is: {1}", i, result);

            String str = "hEILo hI";
            str = str.ToProper();
            Console.WriteLine(str);
            
        }
    }
}
