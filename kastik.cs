using System;
namespace kastik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cherty = Convert.ToInt32(Console.ReadLine());
            natural(cherty);
        }
        static void natural(int cherty)
        {
            for (int i = 0; i < cherty; i++)
            {
                Console.Write("-");
            }

        }
    }
}