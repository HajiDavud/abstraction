using System;

namespace ConsoleApp1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            DeathStar star1 = new DeathStar();
            star1.FireLaser();

            IVehicle newCar = new Car();
            newCar.Drive();
            
        }
    }


    abstract class SpaceStation
    {
        public abstract void FireLaser();

    }
    class DeathStar : SpaceStation
    {
        public override void FireLaser() => Console.WriteLine("Pew Pew");
    }




    interface IVehicle
    {
        public void Drive();
    }

    class Car : IVehicle
    {

        void IVehicle.Drive()
        {
            Console.WriteLine("car is Driving");
        }
    }

}
