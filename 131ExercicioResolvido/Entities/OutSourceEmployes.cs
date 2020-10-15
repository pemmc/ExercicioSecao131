using System;
namespace _131ExercicioResolvido.Entities
{
    public class OutSourceEmployes : Employe
    {

        public double additionalCharge { get; set; }

        public OutSourceEmployes()
        {


        }

        public OutSourceEmployes(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {

            this.additionalCharge = additionalCharge;

        }

        public override double Payment()
        {

            return base.Payment() + 1.1 * additionalCharge;

        }
    }
}
