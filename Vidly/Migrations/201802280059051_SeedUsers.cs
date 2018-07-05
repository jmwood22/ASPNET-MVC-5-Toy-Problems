namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'69ce359d-0438-4836-9cba-e2ab5bef4a62', N'guest@vidly.com', 0, N'AO/REp5Oqb+hHXjr/CYBaE4KkE4R8JeWFQdKBRPymcMuWkorS4FDhB5bFNR/FckEig==', N'dc67cbd2-8725-4793-98c0-dda79fcb98f6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e260d57e-3d2d-4972-a02f-a52364615cb8', N'admin@vidly.com', 0, N'AB2tWeb71pYa7pLM7grZKoq8ZxDlg4KJ7Wf4aoD+wa1WEASnApkOyBbfUQ80z86+3Q==', N'6642aaf5-fec3-43a1-810a-01e400a2e495', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'54e20d68-09be-4091-a2e3-42566a354538', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e260d57e-3d2d-4972-a02f-a52364615cb8', N'54e20d68-09be-4091-a2e3-42566a354538')
 ");
        }
        
        public override void Down()
        {
        }
    }
}
