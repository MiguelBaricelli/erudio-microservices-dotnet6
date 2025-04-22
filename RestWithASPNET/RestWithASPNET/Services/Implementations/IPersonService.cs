using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);

        List<Person> FindAll();

        Person Update(Person person);

        Person FindByID(int id);

        void Delete(int id);
    }
}
