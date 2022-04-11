using System.Collections.Generic;

namespace wayfiner_dotnet.Interfaces
{
    public interface IRepository<T, Tid>
    {
        List<T> GetAll();

        T GetById(int id);

        T Create(T data);

        T Edit(T data);

        string Delete(Tid id);
    }
}