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
                new User { UserName = "FlyingMonkey", FirstName = "Jake", LastName = "Russ", Password = "pass123", UserType = 1},
                new User { UserName = "Schnitzleman", FirstName = "Philipp", LastName = "Schmidt", Password = "123pass", UserType = 2},
                new User { UserName = "NewBranchTherapy", FirstName = "New", LastName = "Branch", Password = "Pass!@#", UserType = 3},
                new User { UserName = "TrueYou", FirstName = "True", LastName = "You", Password = "!@#Pass", UserType = 4}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var usertype = new List<UserType>
            {
                new UserType {UserTypeID = 1, TypeOfUser = "Personal"},
                new UserType {UserTypeID = 2, TypeOfUser = "Personal"},
                new UserType {UserTypeID = 3, TypeOfUser = "Service Provider"},
                new UserType {UserTypeID = 4, TypeOfUser = "Support Group"}
            };
            usertype.ForEach(s => context.UserTypes.Add(s));
            context.SaveChanges();

            var location = new List<LocationInfo>
            {
                new LocationInfo {LocationInfoID = 1, UserID = 1, StreetAddress1 = "1234 MyStreet street", City = "Dallas", StateID = "Texas", Zipcode = 12345},
                new LocationInfo {LocationInfoID = 2, UserID = 2, StreetAddress1 = "4321 ADifferent street", City = "Fort Worth", StateID = "Texas", Zipcode = 54321},
                new LocationInfo {LocationInfoID = 3, UserID = 3, StreetAddress1 = "001 Business Avenue", StreetAddress2 = "Suite 12B", StateID = "North Carolina", Zipcode = 93847},
                new LocationInfo {LocationInfoID = 4, UserID = 4, StreetAddress1 = "100 NotABusiness Avenue", StateID = "North Carolina", Zipcode = 93847}
            };
            location.ForEach(s => context.Locations.Add(s));
            context.SaveChanges();

            var phoneNumber = new List<PhoneNumber>
            {
                new PhoneNumber {PhoneNumberID = 1, UserID = 1, PhoneNum = "972-214-8877"},
                new PhoneNumber {PhoneNumberID = 2, UserID = 2, PhoneNum = "214-972-7788"},
                new PhoneNumber {PhoneNumberID = 3, UserID = 3, PhoneNum = "123-456-7890"},
                new PhoneNumber {PhoneNumberID = 4, UserID = 3, PhoneNum = "321-654-0987"},
                new PhoneNumber {PhoneNumberID = 5, UserID = 4, PhoneNum = "555-555-5555"}
            };
            phoneNumber.ForEach(s => context.PhoneNumbers.Add(s));
            context.SaveChanges();

            var emails = new List<Email>
            {
                new Email {EmailID = 1, UserID = 1, EmailAddress = "jakeruss@myfakeemail.com"},
                new Email {EmailID = 2, UserID = 3, EmailAddress = "newbranchtherapy@fakeemail.com"},
                new Email {EmailID = 3, UserID = 4, EmailAddress = "trueyou@fakeemail.com"}
            };
            emails.ForEach(s => context.Emails.Add(s));
            context.SaveChanges();

            var biography = new List<UserBiography>
            {
                new UserBiography {BioID = 1, UserID = 1, BioInfo = "I was born on the plains of the great American West..."},
                new UserBiography {BioID = 2, UserID = 2, BioInfo = "There once was a man from Spain..."},
                new UserBiography {BioID = 3, UserID = 3, BioInfo = "We specialize in speech and ABA therapy..."},
                new UserBiography {BioID = 4, UserID = 4, BioInfo = "We are the largest support group in the area. Please stop by or give us a call..."}
            };
            biography.ForEach(s => context.Biographies.Add(s));
            context.SaveChanges();

            var posts = new List<Posting>
            {
                new Posting {PostID = 1, UserID = 3, PostingTime = DateTime.Now, Post = "Come to our Christmas party this week at 5pm!"}
            };
            posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();

            var likepost = new List<LikePost>
            {
                new LikePost {UserID = 1, PostID = 1},
                new LikePost {UserID = 2, PostID = 1}
            };
            likepost.ForEach(s => context.LikePosts.Add(s));
            context.SaveChanges();

            var follow = new List<FollowUser>
            {
                new FollowUser {FollowingUser = 1, UserBeingFollowed = 3 },
                new FollowUser {FollowingUser = 2, UserBeingFollowed = 3 },
                new FollowUser {FollowingUser = 1, UserBeingFollowed = 4 },
                new FollowUser {FollowingUser = 2, UserBeingFollowed = 4 },
                new FollowUser {FollowingUser = 1, UserBeingFollowed = 2 },
                new FollowUser {FollowingUser = 2, UserBeingFollowed = 1 }
            };
            follow.ForEach(s => context.Following.Add(s));
            context.SaveChanges();
        }
    }
}
