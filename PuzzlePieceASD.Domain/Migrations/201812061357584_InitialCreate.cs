namespace PuzzlePieceASD.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBiographies",
                c => new
                    {
                        BioID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BioInfo = c.String(),
                    })
                .PrimaryKey(t => t.BioID);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.EmailID);
            
            CreateTable(
                "dbo.FollowUsers",
                c => new
                    {
                        FollowingUser = c.Int(nullable: false, identity: true),
                        UserBeingFollowed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FollowingUser);
            
            CreateTable(
                "dbo.LikePosts",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.LocationInfoes",
                c => new
                    {
                        LocationInfoID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        StreetAddress3 = c.String(),
                        City = c.String(maxLength: 50),
                        StateID = c.String(maxLength: 25),
                        Zipcode = c.Int(),
                    })
                .PrimaryKey(t => t.LocationInfoID);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PhoneNum = c.String(),
                    })
                .PrimaryKey(t => t.PhoneNumberID);
            
            CreateTable(
                "dbo.Postings",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Post = c.String(),
                        PostingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Password = c.String(nullable: false),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeID = c.Int(nullable: false, identity: true),
                        TypeOfUser = c.String(),
                    })
                .PrimaryKey(t => t.UserTypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
            DropTable("dbo.Postings");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.LocationInfoes");
            DropTable("dbo.LikePosts");
            DropTable("dbo.FollowUsers");
            DropTable("dbo.Emails");
            DropTable("dbo.UserBiographies");
        }
    }
}
