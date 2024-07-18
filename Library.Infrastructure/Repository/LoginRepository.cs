using Library.Infrastructure.Contexts;
using Library.Infrastructure.IRepository;
using Library.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly LibraryContext context;

        public LoginRepository()
        {
            context = new LibraryContext();
        }
        public User GetByUsername()
        {
            var x = context.User.Include(loginAccesss => loginAccesss.LoginAccess.UserType).AsNoTracking().FirstOrDefault();
            return x;
        }
    }
}
