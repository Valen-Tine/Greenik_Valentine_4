using System;
using System.Collections.Generic;
using System.Text;

namespace ProgaLaba4
{
    public abstract class Educational_institution
    {
        public int number_of_students;
        public int number_of_teachers;
        public int number_of_classes;
        public int year;

        public virtual void Classes()
        {
            Random rnd = new Random();
            number_of_classes = rnd.Next(10, 50);
        }

        public virtual void Teachers()
        {
            Random ran = new Random();
            number_of_teachers = ran.Next(30, 300);
        }
    }

}
