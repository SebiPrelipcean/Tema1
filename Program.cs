using System;



namespace NotaStud
{
    class Program
    {
        Random rnd = new Random();
        static void Main()
        {
            Random rnd = new Random();
            int x;
     for(int i =0;i<20;i++)
            {
                x = rnd.Next(1, 10);
                Console.WriteLine(x);

                if (x >= 5)
                    Console.WriteLine("PROMOVAT");
                else
                    Console.WriteLine("NEPROMOVAT");
            }
            Console.ReadKey();

        }
    }
}
