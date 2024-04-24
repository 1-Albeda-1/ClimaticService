namespace ClimaticService.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrokenTypes",
                c => new
                    {
                        IdBrokenType = c.Int(nullable: false, identity: true),
                        BrokenTypeTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdBrokenType);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        IdRequest = c.Int(nullable: false, identity: true),
                        DateAdd = c.DateTime(nullable: false),
                        DateClose = c.DateTime(),
                        Spares = c.String(),
                        EquipmentModel = c.String(),
                        Description = c.String(),
                        EquipmentTypeId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        WorkerId = c.Int(),
                        BrokenTypeId = c.Int(),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdRequest)
                .ForeignKey("dbo.BrokenTypes", t => t.BrokenTypeId)
                .ForeignKey("dbo.Users", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.WorkerId)
                .ForeignKey("dbo.EquipmentTypes", t => t.EquipmentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.EquipmentTypeId)
                .Index(t => t.ClientId)
                .Index(t => t.WorkerId)
                .Index(t => t.BrokenTypeId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        IdComment = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        UserId = c.Int(),
                        RequestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdComment)
                .ForeignKey("dbo.Requests", t => t.RequestId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.RequestId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        IdRole = c.Int(nullable: false, identity: true),
                        RoleTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdRole);
            
            CreateTable(
                "dbo.EquipmentTypes",
                c => new
                    {
                        IdEquipmentType = c.Int(nullable: false, identity: true),
                        EquipmentTypeTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdEquipmentType);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        IdStatus = c.Int(nullable: false, identity: true),
                        StatusTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdStatus);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Requests", "EquipmentTypeId", "dbo.EquipmentTypes");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Requests", "WorkerId", "dbo.Users");
            DropForeignKey("dbo.Requests", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.Requests", "BrokenTypeId", "dbo.BrokenTypes");
            DropIndex("dbo.Comments", new[] { "RequestId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Requests", new[] { "StatusId" });
            DropIndex("dbo.Requests", new[] { "BrokenTypeId" });
            DropIndex("dbo.Requests", new[] { "WorkerId" });
            DropIndex("dbo.Requests", new[] { "ClientId" });
            DropIndex("dbo.Requests", new[] { "EquipmentTypeId" });
            DropTable("dbo.Status");
            DropTable("dbo.EquipmentTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.Comments");
            DropTable("dbo.Users");
            DropTable("dbo.Requests");
            DropTable("dbo.BrokenTypes");
        }
    }
}
