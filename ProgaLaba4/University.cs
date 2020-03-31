using System;
using System.Collections.Generic;
using System.Text;

namespace ProgaLaba4
{
    public class University : Educational_institution
    {
        public University(int students_uni)
        {
            number_of_students = students_uni;
        }

        public override void Classes()
        {
            base.Classes();
            Console.WriteLine($"Количество факультетов в университете: {number_of_classes}.");

        }
        public override void Teachers()
        {
            base.Teachers();
            Console.WriteLine($"Количество учителей в университете: {number_of_teachers}.");
        }

    }

    public class Faculty : University
    {
        public Faculty(int students_uni) : base(students_uni)
        {

        }
        public void Year()
        {
            Console.WriteLine("Год основания ФИОТ - 1962.");
        }

    }
}
