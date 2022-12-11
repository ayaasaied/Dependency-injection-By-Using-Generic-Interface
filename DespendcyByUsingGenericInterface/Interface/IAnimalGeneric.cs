namespace DespendcyByUsingGenericInterface.Interface
{
    public interface IAnimalGeneric <T> where T : class
    {
        T GetAll();
        T Update (T model);
        T Delete (T model);
        T GetById (int id);

    }
}
