using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF.Tutorial.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tutorial");

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "tutorial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    LegalName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "now()"),
                    CreatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "tutorial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExternalObjectId = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "now()"),
                    CreatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCompanyAccess",
                schema: "tutorial",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: false, defaultValueSql: "now()"),
                    CreatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "timestamptz", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanyAccess", x => x.Id);
                    table.ForeignKey(
                        name: "USERCOMPANYACCESS_COMPANY_FK",
                        column: x => x.CompanyId,
                        principalSchema: "tutorial",
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "USERCOMPANYACCESS_USER_FK",
                        column: x => x.UserId,
                        principalSchema: "tutorial",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "tutorial",
                table: "Company",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedUser", "DeletedAt", "LegalName", "UpdatedAt", "UpdatedUser" },
                values: new object[,]
                {
                    { new Guid("8f2c8b6e-4b2e-4bb4-9f31-0b7f4e2b9d9d"), "0000001", new DateTimeOffset(new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", null, "Company 1", null, null },
                    { new Guid("a1d4cbe2-0d18-4c57-8d8a-7a2de9131df6"), "0000002", new DateTimeOffset(new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", null, "Company 2", null, null }
                });

            migrationBuilder.InsertData(
                schema: "tutorial",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "CreatedUser", "DeletedAt", "DisplayName", "Email", "ExternalObjectId", "UpdatedAt", "UpdatedUser" },
                values: new object[] { new Guid("e3d5b2f4-91a7-4ac6-9c40-2df5f1e7b6a8"), new DateTimeOffset(new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", null, "User", "tutorial@test.com", "c624b0ea-1a43-47e4-8c51-d1b64091ef0a", null, null });

            migrationBuilder.InsertData(
                schema: "tutorial",
                table: "UserCompanyAccess",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "CreatedUser", "DeletedAt", "UpdatedAt", "UpdatedUser", "UserId" },
                values: new object[] { new Guid("f0c8a3d9-91c4-44bb-af40-6b77c0dd3d8b"), new Guid("8f2c8b6e-4b2e-4bb4-9f31-0b7f4e2b9d9d"), new DateTimeOffset(new DateTime(2025, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", null, null, null, new Guid("e3d5b2f4-91a7-4ac6-9c40-2df5f1e7b6a8") });

            migrationBuilder.CreateIndex(
                name: "COMPANY_UQ1",
                schema: "tutorial",
                table: "Company",
                column: "Code",
                unique: true,
                filter: "\"DeletedAt\" IS NULL");

            migrationBuilder.CreateIndex(
                name: "USER_UQ1",
                schema: "tutorial",
                table: "User",
                column: "Email",
                unique: true,
                filter: "\"DeletedAt\" IS NULL");

            migrationBuilder.CreateIndex(
                name: "USER_UQ2",
                schema: "tutorial",
                table: "User",
                column: "ExternalObjectId",
                unique: true,
                filter: "\"DeletedAt\" IS NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanyAccess_CompanyId",
                schema: "tutorial",
                table: "UserCompanyAccess",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "USERCOMPANYACCESS_UQ1",
                schema: "tutorial",
                table: "UserCompanyAccess",
                columns: new[] { "UserId", "CompanyId" },
                unique: true,
                filter: "\"DeletedAt\" IS NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCompanyAccess",
                schema: "tutorial");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "tutorial");

            migrationBuilder.DropTable(
                name: "User",
                schema: "tutorial");
        }
    }
}
