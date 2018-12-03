using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using PuzzlePieceASD.Domain.Concrete;

namespace PuzzlePieceASD.Domain.DAL
{
    public class UserContext : DbContext
    {
        public UserContext () : base("UserContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LocationInfo> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<FollowUser> Following { get; set; }
        public DbSet<LikePost> LikePosts { get; set; }
    }
}
