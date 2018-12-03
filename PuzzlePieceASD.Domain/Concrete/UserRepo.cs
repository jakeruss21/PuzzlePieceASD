using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PuzzlePieceASD.Domain.Abstract;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class UserRepo : IUserRepo
    {
        private SignInContext context = new SignInContext();

        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}
