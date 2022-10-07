using authentication.Model;
using BookStore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace authentication.Repository
{
    public interface IBookRepository
    {
        Task<List<Books>> getAllBook();
        Task<Books> getBookByid(int id);
    }
}