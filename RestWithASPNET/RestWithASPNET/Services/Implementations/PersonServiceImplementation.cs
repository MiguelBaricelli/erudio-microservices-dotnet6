using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(int id)
        {
           
        }

        public List<Person> FindAll()
        {
            
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person name" + i,
                LastName = "Person lastName" + i,
                Address = "Some address" + i,
                Gender = "M"

            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Person FindByID(int id)
        {
               return new Person { 
                Id = IncrementAndGet(),
                FirstName = "Miguel",
                LastName = "Augusto",
                Address = "São paulo",
                Gender = "M"
               
               };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
