using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Patern22
{
    abstract class Car
    {
        public enum CarType
        {
            Bas, Truck, Tractor,
            BusFan,
            TruckFan,
            TractorFan
        }
        public interface ICar
        {
            void IRide();
            void IBreak();
            void IHeavy();
            void ILiftingcapacity();
        }

        public class BusFan : ICar
        {
            public void IRide()
            {
                Console.WriteLine("On");
            }

            public void IBreak()
            {
                Console.WriteLine("No break");
            }

            public void IHeavy()
            {
                Console.WriteLine("2000 kg");
            }

            public void ILiftingcapacity()
            {
                Console.WriteLine("4000 kg");
            }
        }
        public class TruckFan : ICar
        {
            public void IRide()
            {
                Console.WriteLine("Off");
            }

            public void IBreak()
            {
                Console.WriteLine("Break");
            }

            public void IHeavy()
            {
                Console.WriteLine("3500 kg");
            }

            public void ILiftingcapacity()
            {
                Console.WriteLine("5000 kg");
            }

        }
        public class TractorFan : ICar
        {
            public void IRide()
            {
                Console.WriteLine("On/Off");
            }

            public void IBreak()
            {
                Console.WriteLine("No break");
            }

            public void IHeavy()
            {
                Console.WriteLine("1000 kg");
            }

            public void ILiftingcapacity()
            {
                Console.WriteLine("500 kg");
            }

        }
        public interface IFanFactory
        {
            ICar CreateFan(CarType carType);
        }

        public class FanFactory : IFanFactory
        {
            public ICar CreateFan(CarType carType)
            {
                switch (carType)
                {
                    case CarType.BusFan:
                        return new BusFan();
                    case CarType.TruckFan:
                        return new TruckFan();
                    case CarType.TractorFan:
                        return new TractorFan();
                    default:
                        return new BusFan();
                }
            }
        }
    }
}
