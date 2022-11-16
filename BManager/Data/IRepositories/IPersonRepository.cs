using BManager.Models;
using BManager.Queries.Person;
using BManager.Utils;
using BManager.Utils.Abstractions;

namespace BManager.Data.IRepositories
{
    public interface IPersonRepository : IRepository<Person, PersonFilter>
    {
    }
}
