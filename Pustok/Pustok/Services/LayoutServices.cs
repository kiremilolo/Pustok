using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pustok.DAL;
using Pustok.Models;

namespace Pustok.Services
{
    public class LayoutServices
    {
        private readonly PustokDbContext _context;  

        public LayoutServices(PustokDbContext context)
        {
            _context = context;
        }
        public List<Genre> GenreList { get; set; }
        
        public List<Genre> GetGenrees()
        {
            return _context.Genre.ToList();
        }

        public Dictionary<string, string> GetSetting()
        {
            return _context.Settings.ToDictionary(x=> x.Key, x => x.Value); 
        }
        
    }
}
