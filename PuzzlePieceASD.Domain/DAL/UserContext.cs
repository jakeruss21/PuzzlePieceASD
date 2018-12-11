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

        public DbSet<UserType> UserTypes        { get; set; }
        public DbSet<User> Users                { get; set; }
        public DbSet<LocationInfo> Locations    { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers  { get; set; }
        public DbSet<Email> Emails              { get; set; }
        public DbSet<UserBiography> Biographies { get; set; }
        public DbSet<Posting> Posts             { get; set; }
        public DbSet<FollowUser> Following      { get; set; }
        public DbSet<LikePost> LikePosts        { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
