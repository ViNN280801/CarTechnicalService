using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTechnicalService.Objects
{
    public enum CarType { light, truck }
    public enum AccessLvl { Mechanic, Driver }
    public enum Status { Active, NonActive }
    public class Car
    {
        public int id { get; set; }
        public Car() { }
        public Car(int id, string GarageNumber, string Model, string Name, int YearOfProduce)
        {
            this.id = id;
            this.Model = Model;
            this.GarageNumber = GarageNumber;
            this.Name = Name;
            this.YearOfProduce = YearOfProduce;
        }
        public Car(int id, string Model, string Name, int YearOfProduce)
        {
            this.id = id;
            this.Model = Model;
            this.Name = Name;
            this.YearOfProduce = YearOfProduce;
        }
        public string Model { get; set; }
        public int YearOfProduce { get; set; }
        public string Name { get; set; }
        public CarType carType { get; set; }
        public string GarageNumber { get; set; }
        public string AdditionalComponent { get; set; }
        public int AdditionalComponentCode { get; set; }
        public Status status { get; set; }
    }

    public class Component
    {
        public int id { get; set; }
        public Component() { }
        public Component(int id, string Name, int CodeOfComponent)
        {
            this.id = id;
            this.Name = Name;
            this.CodeOfComponent = CodeOfComponent;
        }
        public string Name { get; set; }
        public int CodeOfComponent { get; set; }
    }

    public class Project
    {
        public int id { get; set; }
        public Project() { }
        public Project(int id, string NameOfProject)
        {
            this.id = id;
            this.NameOfProject = NameOfProject;
        }
        public string NameOfProject { get; set; }

        public static explicit operator Project(string v)
        {
            throw new NotImplementedException();
        }
    }

    public class Users
    {
        public int id { get; set; }
        public Users() { }
        public Users(int id, string Login, string Password)
        { 
            this.id = id;
            this.Login = Login;
            this.Password = Password;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public AccessLvl access { get; set; }
        public Project project { get; set; }
    }

    public class BreakOut
    {
        public int id { get; set; }
        public BreakOut() { }
        public BreakOut(int id, DateTime DateOfCreating)
        {
            this.id = id;
            this.DateOfCreating = DateOfCreating;
        }
        public DateTime DateOfCreating { get; set; }
        public Car car { get; set; }
        public string DescriptionOfBreakOut { get; set; }
        public string Recomendation { get; set; }
        public Users user { get; set; }
    }
}