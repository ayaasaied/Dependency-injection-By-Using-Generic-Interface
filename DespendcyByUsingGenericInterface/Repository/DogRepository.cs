using DespendcyByUsingGenericInterface.Interface;
using DespendcyByUsingGenericInterface.Models;

namespace DespendcyByUsingGenericInterface.Repository
{
    public class DogRepository : IAnimalGeneric<Dog>
    {
        public Dog Delete(Dog model)
        {
            throw new NotImplementedException();
        }

        public Dog GetAll()
        {
            throw new NotImplementedException();
        }

        public Dog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Dog Update(Dog model)
        {
            throw new NotImplementedException();
        }
    }
}
