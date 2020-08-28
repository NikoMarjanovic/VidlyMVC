namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useraccounts : DbMigration
    {
        public override void Up()
        {
            Sql(@" INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'7e243b1d-c65f-4c82-b56b-50453dbbdc56', N'admin@vidly.com', 0, N'AK0b+aZibZlfNpMUXXD28GJ1xloszLxrNQpFZAXmSlApZHUupYPZRrFgDecVOUW8Pg==', N'a5fce3f1-13aa-44cb-bea4-1abc0eab17f3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'f6a4ee82-bfca-4d5d-bff1-31fdf1c98446', N'guest@vidly.com', 0, N'AOdYAwjf5fxJQAXjqlRScb6mZyR9F8CXWzhlqISjrhYFrdLWfgRbZ9LtMTOvFLQVUQ==', N'5eacb692-65e7-4eda-9467-e6ed636d5949', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
              INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd76d58a3-33d7-400a-8a5e-d5f155bd8e43', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e243b1d-c65f-4c82-b56b-50453dbbdc56', N'd76d58a3-33d7-400a-8a5e-d5f155bd8e43')


");
        }

        public override void Down()
        {
        }
    }
}
