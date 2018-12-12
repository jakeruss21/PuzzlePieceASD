using System;
using System.Collections.Generic;

using PuzzlePieceASD.Domain.Concrete;

namespace PuzzlePieceASD.Domain.DAL
{
    public class UserSeedDatabase : System.Data.Entity.DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed (UserContext context)
        {
            var usertype = new List<UserType>
            {
                new UserType {TypeOfUser = "Personal"},
                new UserType {TypeOfUser = "Personal"},
                new UserType {TypeOfUser = "Service Provider"},
                new UserType {TypeOfUser = "Support Group"}
            };
            usertype.ForEach(s => context.UserTypes.Add(s));
            //context.SaveChanges();

            var users = new List<User>
            {
                new User { UserName = "FlyingMonkey", FirstName = "Jake", LastName = "Russ", Password = "pass123", UserType = 11},
                new User { UserName = "Schnitzleman", FirstName = "Philipp", LastName = "Schmidt", Password = "123pass", UserType = 12},
                new User { UserName = "NewBranchTherapy", FirstName = "New", LastName = "Branch", Password = "Pass!@#", UserType = 13},
                new User { UserName = "TrueYou", FirstName = "True", LastName = "You", Password = "!@#Pass", UserType = 14}
            };
            users.ForEach(s => context.Users.Add(s));
            //context.SaveChanges();

            var location = new List<LocationInfo>
            {
                new LocationInfo {UserID = 11, StreetAddress1 = "1234 MyStreet street", City = "Dallas", StateID = "Texas", Zipcode = 12345},
                new LocationInfo {UserID = 12, StreetAddress1 = "4321 ADifferent street", City = "Fort Worth", StateID = "Texas", Zipcode = 54321},
                new LocationInfo {UserID = 13, StreetAddress1 = "001 Business Avenue", StreetAddress2 = "Suite 12B", StateID = "North Carolina", Zipcode = 93847},
                new LocationInfo {UserID = 14, StreetAddress1 = "100 NotABusiness Avenue", StateID = "North Carolina", Zipcode = 93847}
            };
            location.ForEach(s => context.Locations.Add(s));
            //context.SaveChanges();

            var phoneNumber = new List<PhoneNumber>
            {
                new PhoneNumber {UserID = 11, PhoneNum = "972-214-8877"},
                new PhoneNumber {UserID = 12, PhoneNum = "214-972-7788"},
                new PhoneNumber {UserID = 13, PhoneNum = "123-456-7890"},
                new PhoneNumber {UserID = 13, PhoneNum = "321-654-0987"},
                new PhoneNumber {UserID = 14, PhoneNum = "555-555-5555"}
            };
            phoneNumber.ForEach(s => context.PhoneNumbers.Add(s));
            //context.SaveChanges();

            var emails = new List<Email>
            {
                new Email {UserID = 11, EmailAddress = "jakeruss@myfakeemail.com"},
                new Email {UserID = 13, EmailAddress = "newbranchtherapy@fakeemail.com"},
                new Email {UserID = 14, EmailAddress = "trueyou@fakeemail.com"}
            };
            emails.ForEach(s => context.Emails.Add(s));
            //context.SaveChanges();

            var biography = new List<UserBiography>
            {
                new UserBiography {UserID = 11, BioInfo = "I was born on the plains of the great American West..."},
                new UserBiography {UserID = 12, BioInfo = "There once was a man from Spain..."},
                new UserBiography {UserID = 13, BioInfo = "We specialize in speech and ABA therapy..."},
                new UserBiography {UserID = 14, BioInfo = "We are the largest support group in the area. Please stop by or give us a call..."}
            };
            biography.ForEach(s => context.Biographies.Add(s));
            //context.SaveChanges();

            var posts = new List<Posting>
            {
                new Posting {UserID = 13, PostingTime = DateTime.Now, Post = "Come to our Christmas party this week at 5pm!"}
            };
            posts.ForEach(s => context.Posts.Add(s));
            //context.SaveChanges();

            var follow = new List<FollowUser>
            {
                new FollowUser {FollowingUser = 11, UserBeingFollowed = 13 },
                new FollowUser {FollowingUser = 12, UserBeingFollowed = 13 },
                new FollowUser {FollowingUser = 11, UserBeingFollowed = 14 },
                new FollowUser {FollowingUser = 12, UserBeingFollowed = 14 },
                new FollowUser {FollowingUser = 11, UserBeingFollowed = 12 },
                new FollowUser {FollowingUser = 12, UserBeingFollowed = 11 }
            };
            follow.ForEach(s => context.Following.Add(s));
            //context.SaveChanges();
            
            var likepost = new List<LikePost>
            {
                new LikePost {UserID = 11, PostID = 1},
                new LikePost {UserID = 12, PostID = 1}
            };
            likepost.ForEach(s => context.LikePosts.Add(s));
            //context.SaveChanges();
        }
    }
}
