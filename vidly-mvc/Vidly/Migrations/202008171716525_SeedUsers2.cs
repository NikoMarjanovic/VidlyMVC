namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'97298717-740f-441f-9b95-afb0a05dc1a3', N'admin@vidly.com', 0, N'AC1wK8lJ8ZX/NYjDU8G0x46o0g7faW5NSKcdtvY36LBuvnB1kzIbWl9ahpNZtJuqHg==', N'c4f0b43b-7d82-4592-88e4-bc40c6bd0c96', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com', N'qweqweq', N'5555555555')
INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES(N'bac35cad-93cf-41f4-911b-308658e9ad2e', N'guest@vidly.com', 0, N'AO6jVTjGh62IDhbtzmIKQDU+TCYda6yTqWkShTU5pIGD6CX6htTLjHFIha2V0LPn4g==', N'f93aefce-8eb6-40e2-8c95-b0ded34a8203', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com', N'qweqweq', N'555555555')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'562b4342-a605-4c60-94e2-6317a11e3886', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'97298717-740f-441f-9b95-afb0a05dc1a3', N'562b4342-a605-4c60-94e2-6317a11e3886')
");
        }

        public override void Down()
        {
        }
    }
}
