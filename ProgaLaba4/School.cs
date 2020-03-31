using System;
using System.Collections.Generic;
using System.Text;

namespace ProgaLaba4
{
    public class School : Educational_institution
    {
        public School(int students_sch)
        {
            number_of_students = students_sch;
        }

        public override void Classes()
        {
            base.Classes();
            Console.WriteLine($"Количество классов в школе: {number_of_classes}.");

        }

        public override void Teachers()
        {
            base.Teachers();
            Console.WriteLine($"Количество учителей в школе: {number_of_teachers}.");
        }

        public void Year()
        {
            Console.WriteLine("Год основания школы - 1989.");
        }
    }

}
