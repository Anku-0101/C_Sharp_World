using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace UnityContainerPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>();
            //container.RegisterType<ICar, Ford>("Key");

            //container.RegisterType<Driver>("LuxuryCar", new InjectionConstructor(container.Resolve<ICar>("Key")));
            //var driver = container.Resolve<Driver>("LuxuryCar");
            var driver = container.Resolve<Driver>();
            driver.RunCar();
            driver.RunCar();

            //var _driver = container.Resolve<Driver>("LuxuryCar");
            var _driver = container.Resolve<Driver>();
            _driver.RunCar();
            Console.ReadKey();

            //Unity container will inject the
            //last registered type if you register multiple mappings of the same type.

            //Unity container will not create a new instance for the registered type
            //and we will use the same instance every time.. In case of registering via a key

            //Driver driver = new Driver(new Audi());
            //driver.RunCar();
            //driver.RunCar();
            //Console.Read();
        }

    }

    public class Driver
    {
        private ICar _car;

        public Driver(ICar car)
        {
            this._car = car;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }

}
