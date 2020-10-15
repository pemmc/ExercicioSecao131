using System;
namespace _131ExercicioResolvido.Entities
{
    public class Employe
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employe()
        {

            //Construtor padrão

        }

        public Employe(string name, int hours, double valuePerHour)
        {

            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;

        }

        public virtual double Payment()
        {

            return Hours * ValuePerHour;

        }
    }
}
