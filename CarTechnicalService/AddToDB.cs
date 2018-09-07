using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB.Shell;
using LiteDB;
using CarTechnicalService.Objects;

namespace CarTechnicalService
{
    public static class AddToDB
    {
        public static void Create(Car addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Car>("car");
                d.Insert(addnew);
            }
        }
        public static IEnumerable<Car> ReturnAllCars()
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                return db.GetCollection<Car>("car").FindAll();
            }
        }
        public static void Update(Car addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Car>("car");
                d.Update(addnew);
            }
        }
        public static void Delete(Car Delete)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Car>("car");
                d.Delete(Delete.id);
            }
        }




        public static void Create(Component addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Component>("component");
                d.Insert(addnew);
            }
        }
        public static IEnumerable<Component> ReturnAllComponents()
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                return db.GetCollection<Component>("component").FindAll();
            }
        }
        public static void Update(Component addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Component>("component");
                d.Update(addnew);
            }
        }
        public static void Delete(Component Delete)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Component>("component");
                d.Delete(Delete.id);
            }
        }





        public static void Create(Project addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Project>("project");
                d.Insert(addnew);
            }
        }
        public static IEnumerable<Project> ReturnAllProjects()
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                return db.GetCollection<Project>("project").FindAll();
            }
        }
        public static void Update(Project addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Project>("project");
                d.Update(addnew);
            }
        }
        public static void Delete(Project Delete)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Component>("project");
                d.Delete(Delete.id);
            }
        }




        public static void Create(Users addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Users>("users");
                d.Insert(addnew);
            }
        }
        public static IEnumerable<Users> ReturnAllUsers()
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                return db.GetCollection<Users>("users").FindAll();
            }
        }
        public static void Update(Users addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Users>("users");
                d.Update(addnew);
            }
        }
        public static void Delete(Users Delete)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<Users>("users");
                d.Delete(Delete.id);
            }
        }





        public static void Create(BreakOut addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<BreakOut>("break_out");
                d.Insert(addnew);
            }
        }
        public static IEnumerable<BreakOut> ReturnAllBreakOuts()
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                return db.GetCollection<BreakOut>("break_out").FindAll();
            }
        }
        public static void Update(BreakOut addnew)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<BreakOut>("break_out");
                d.Update(addnew);
            }
        }
        public static void Delete(BreakOut Delete)
        {
            using (var db = new LiteDatabase(@"CarTechnicalService.db"))
            {
                var d = db.GetCollection<BreakOut>("break_out");
                d.Delete(Delete.id);
            }
        }
    }
}