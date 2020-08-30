using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using hrapi.Database;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Repository
{
    public class NewsRepository : INewsRepository
    {
        private IApplicationDbContext _dbcontext;

        public NewsRepository(IApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }

        public async Task<int> CreateNews(News news)
        {
            _dbcontext.news.Add(news);
            await _dbcontext.SaveChanges();
            return news.NewsID;
        }

        public async Task<News> GetNewsById(int id)
        {
            var news = await _dbcontext.news.Where(x => x.NewsID == id).FirstOrDefaultAsync();
            return news;
        }
    }
}
