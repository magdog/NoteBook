using notebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notebook.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Notebookcontext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Persons.Any())
            {
                return;   // DB has been seeded
            }

            var persons = new Person[]
            {
            new Person{FirstMidName="Carson",LastName="Alexander",DateOfBirth=DateTime.Parse("2005-09-01"),Phone="89999109101"},
            new Person{FirstMidName="Meredith",LastName="Alonso",DateOfBirth=DateTime.Parse("2002-09-01"),Phone="89999109102"},
            new Person{FirstMidName="Arturo",LastName="Anand",DateOfBirth=DateTime.Parse("2003-09-01"),Phone="89999109103"},
            new Person{FirstMidName="Gytis",LastName="Barzdukas",DateOfBirth=DateTime.Parse("2002-09-01"),Phone="89999109104"},
            new Person{FirstMidName="Yan",LastName="Li",DateOfBirth=DateTime.Parse("2002-09-01"),Phone="89999109105"},
            new Person{FirstMidName="Peggy",LastName="Justice",DateOfBirth=DateTime.Parse("2001-09-01"),Phone="89999109106"},
            new Person{FirstMidName="Laura",LastName="Norman",DateOfBirth=DateTime.Parse("2003-09-01"),Phone="89999109107"},
            new Person{FirstMidName="Nino",LastName="Olivetto",DateOfBirth=DateTime.Parse("2005-09-01"),Phone="89999109108"}
            };
            foreach (Person person in persons)
            {
                context.Persons.Add(person);
            }
            context.SaveChanges();
        }

}
}
