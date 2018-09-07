using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService;
using CarTechnicalService.Functions;
using CarTechnicalService.Objects;

namespace MainCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCreatingModule carCreating = new CarCreatingModule();
            Car car = new Car();
            Component component = new Component();

            Console.WriteLine("1.Enter car id: ");
            car.id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("2.Enter garage number: ");
            car.GarageNumber = Console.ReadLine();
            Console.WriteLine("3.Enter model: ");
            car.Model = Console.ReadLine();
            Console.WriteLine("4.Enter firm: ");
            car.Name = Console.ReadLine();
            Console.WriteLine("5.Enter year of produce: ");
            car.YearOfProduce = Int32.Parse(Console.ReadLine());

            AddToDB.Create(car);

            int ch;
            Console.WriteLine("If you want to delete all database, enter 1, else enter 0...");

            ch = Int32.Parse(Console.ReadLine());
            if (ch == 1)
                AddToDB.Delete(car);
            else if (ch == 0)
            {
                int ch2;

                Console.WriteLine("1.Searching by garage number and model;");
                Console.WriteLine("2.Attach additional component;");
                Console.WriteLine("3.Set status of your car;");

                ch2 = Int32.Parse(Console.ReadLine());

                if(ch2 == 1)
                {
                    Console.WriteLine("2.Enter garage number: ");
                    car.GarageNumber = Console.ReadLine();
                    Console.WriteLine("3.Enter model: ");
                    car.Model = Console.ReadLine();

                    carCreating.SearchCarsByGarageNumberAndModel(car.GarageNumber, car.Model);
                }
                else if(ch2 == 2)
                {
                    Console.WriteLine("Enter component id: ");
                    component.id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter component name: ");
                    component.Name = Console.ReadLine();
                    Console.WriteLine("Enter code of component: ");
                    component.CodeOfComponent = Int32.Parse(Console.ReadLine());

                    carCreating.AttachComponent(component);
                }
                else if(ch2 == 3)
                {
                    Console.WriteLine("Set status:\nActive[1]\nNon-active[0]\n");

                    int ch3;
                    ch3 = Int32.Parse(Console.ReadLine());
                    if (ch3 == 0)
                    {
                        carCreating.SetStatus(Status.NonActive);
                    }
                    else if (ch3 == 1)
                    {
                        carCreating.SetStatus(Status.Active);
                    }
                    else throw new Exception("You entered invalid value!");
                }
            }
            else throw new Exception("You entered invalid value!");
        }
    }
}