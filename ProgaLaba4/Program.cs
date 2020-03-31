using System;

namespace ProgaLaba4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество учеников в школе: ");
            int studens_sch = Convert.ToInt32(Console.ReadLine());
            School school = new School(studens_sch);

            Console.Write("Введите количество учеников в университете: ");
            int studens_uni = Convert.ToInt32(Console.ReadLine());
            University university = new University(studens_uni);
            university.Classes();
        }
    }
}
