using PersonGame.Domain;
using PersonGame.Domain.Interface;

namespace PersonGame.Domain.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Game> GameRepository { get; }
        IRepository<Person> PersonRepository { get; }

        void Commit();
        void Dispose();
    }
}