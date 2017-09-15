using IInfra;
using IModels.Commons;
using Infra;
using Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebTestProject.Controllers
{
    [RoutePrefix("v1/persons")]
    public class PersonsController : ApiController
    {
        private string Name { get; set; }
        private static IList<Person> _persons = new List<Person>();
        private IPersonDataAccess _personDataAccces;

        public PersonsController()
        {
            _personDataAccces = new PersonDataAccess();
        }

        [Route("{id}/name")]
        [HttpGet]
        public string GetName(int id)
        {
            
            Name = "Jeferson dos Anjos";
            return Name;
        }

        [Route("{id}/old")]
        [HttpGet]
        public int GetOld(int id)
        {

            return id;
        }
        [Route("{id}/surname")]
        [HttpGet]
        public string GetSurName(int id)
        {
            return "dos Anjos";
        }

        [Route("{id}")]
        [HttpGet]
        public IPerson GetPersons(int id)
        {
            return _personDataAccces.Get(id);
            //return _persons[id];
        }

        [Route]
        [HttpGet]
        public IList<Person> GetPersons()
        {
            return _persons;
        }

        [Route]
        [HttpPost]
        public Person PostPersons(Person person)
        {
            _persons.Add(person);
            person.Id = _persons.Count -1;
            return person;
        }
    }
}
