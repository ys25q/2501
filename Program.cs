using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] Worker = new Worker[]
                        {
                new Worker ("Petrov", "Ivan", 45, 3, "ofic"),
                new Worker ("Petrenko", "Petro", 25, 8, "ofic"),
                new Worker ("Ivanenko", "Ivan", 55, 7, "ofic"),
                new Worker ("Sydorenko", "Sydr", 61, 9, "ofic"),

                        };

            foreach (Worker item in Worker)
            {
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Zp);
                Console.WriteLine(item.Status);
                Console.WriteLine(item.Zp *80.5);
                Console.WriteLine(item.IsPensioner);

                Console.WriteLine("                       ");



                //Worker rec = new Worker(5, 8);
                //Console.WriteLine(rec.Area);
                //double area = rec.Area;
                //Console.WriteLine(area);
            }















        }

        /* Rectangle1[] rec = new Rectangle1[]
            {
                new Rectangle1 (5, 8),
                new Rectangle1 (3, 8),
                new Rectangle1 (7, 8),
                new Rectangle1 (9, 8),
                new Rectangle1 (5, 9),
            };
            foreach (Rectangle1 item in rec) 
            {
                Console.WriteLine(item.Area);*/

        /* Rectangle1 rec = new Rectangle1 (5, 8);
         Console.WriteLine(rec.Area);
         double area = rec.Area;
         Console.WriteLine(area);*/
    }

}

