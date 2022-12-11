using DespendcyByUsingGenericInterface.Interface;
using DespendcyByUsingGenericInterface.Models;

namespace DespendcyByUsingGenericInterface.Repository
{
    public class CatRepository : IAnimalGeneric<Cat>
    {
        public Cat Delete(Cat model)
        {
            throw new NotImplementedException();
        }

        public Cat GetAll()
        {
            throw new NotImplementedException();
        }

        public Cat GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cat Update(Cat model)
        {
            throw new NotImplementedException();
        }
    }
}
