using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestTask.Models
{
    public class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var personsList = new List<Person>
            {
                new Person{ Name="Aleksandr", Surname="Ovcharenko"},
                new Person{ Name="Ivan", Surname="Ivanov"}
            };
            personsList.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();
        }

    }
}