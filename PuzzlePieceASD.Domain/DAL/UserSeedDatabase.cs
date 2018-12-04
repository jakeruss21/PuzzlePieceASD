using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PuzzlePieceASD.Domain.Concrete;

namespace PuzzlePieceASD.Domain.DAL
{
    public class UserSeedDatabase : System.Data.Entity.DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed (UserContext context)
        {
            var users = new List<User>
            {
                new User { UserName = "FlyingMonkey", FirstName = "Jake", LastName = "Russ", Password = "pass123", UserType = "Personal", UserBio = 1},
                new User { UserName = "Schnitzleman", FirstName = "Philipp", LastName = "Schmidt", Password = "123pass", UserType = "Personal", UserBio = 2 },
                new User { UserName = "NewBranchTherapy", FirstName = "New", LastName = "Branch", Password = "Pass!@#", UserType = "Service Provider", UserBio = 3 },
                new User { UserName = "TrueYou", FirstName = "True", LastName = "You", Password = "!@#Pass", UserType = "Support Group", UserBio = 4 }
            };
        }
    }
}
