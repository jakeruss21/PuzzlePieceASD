using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PuzzlePieceASD.Domain.Abstract;
using PuzzlePieceASD.Domain.DAL;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class UserRepo : IUserRepo
    {
        private UserContext context = new UserContext();

        public IEnumerable<UserType> UserTypes
        {
            get { return context.UserTypes; }
        }
    }
}
