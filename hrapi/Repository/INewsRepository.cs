using System;
using System.Threading.Tasks;
using hrapi.Model;

namespace hrapi.Repository
{
    public interface INewsRepository
    {
        Task<News> GetNewsById(int id);
        Task<int> CreateNews(News news);

    }
}
