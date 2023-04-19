using CRUD_Operations_with_EF.Context;
using CRUD_Operations_with_EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations_with_EF.Services
{
    public class Repository
    {
        public List<Person> Read(string firstName, string lastName, int age)
        {
            using (CRUD_DB db = new())
            {
                return db.People.ToList();
            }
        }
        public void Create(string firstName, string lastName, int age)
        {
            using (CRUD_DB db = new())
            {
                Person person = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                db.People.Add(person);
                db.SaveChanges();
            }
        }

        public void Update(int id, string firstName, string lastName, int age)
        {
            using (CRUD_DB db = new())
            {
                Person person = db.People.Find(id);

                if (person != null)
                {
                    person.FirstName = firstName;
                    person.LastName = lastName; 
                    person.Age = age;   
                    db.SaveChanges();

                }
            }
        }

        public void Delete(int id)
        {
            using (CRUD_DB db = new())
            {
                Person idPerson = db.People.Find(id);

                if (idPerson != null)
                {
                    db.Remove(id);
                    db.SaveChanges();

                }
            }
        }

    }
}
