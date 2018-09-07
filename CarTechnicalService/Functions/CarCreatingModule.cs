using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService.Objects;

namespace CarTechnicalService.Functions
{
    public class CarCreatingModule
    {
        DateTime date = new DateTime();
        BreakOut breakOut = new BreakOut();
        List<Car> cars = new List<Car>();
        Car car = new Car();
        public Car SearchCarsByGarageNumberAndModel(string GarageNumber, string Model)
        {
            if (GarageNumber == car.GarageNumber && Model == car.Model)
            {
                return car;
            }
            else return null;
        }
        public Car AttachComponent(Component component)
        {
            if (car.AdditionalComponent == null)
            {
                car.AdditionalComponent = component.Name;
                car.AdditionalComponentCode = component.CodeOfComponent;
            }
            else
                return null;

            return car;
        }
        public BreakOut CreateBreakOut(DateTime DateOfCreating)
        {
            breakOut.DateOfCreating = DateOfCreating;

            return breakOut;
        }
        public Car SetStatus(Status status)
        {
            car.status = status;

            if (car.status == Status.Active)
                Console.BackgroundColor = ConsoleColor.Green;
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Beep(10000, 1000);
                CreateBreakOut(date);
            }

            return car;
        }
    }
}