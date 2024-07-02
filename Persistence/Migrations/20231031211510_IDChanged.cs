using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IDChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserId",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldSports",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacilityAdministrators",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.RenameColumn(
                name: "RoleId",
                schema: "Auth",
                table: "UserRoles",
                newName: "RoleID"
            );

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "Auth",
                table: "UserRoles",
                newName: "UserID"
            );

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Auth",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleID"
            );

            migrationBuilder
                .AddColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "UserRoles",
                    type: "integer",
                    nullable: false,
                    defaultValue: 0
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                schema: "Auth",
                table: "UserRoles",
                type: "boolean",
                nullable: false,
                defaultValue: false
            );

            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                schema: "Auth",
                table: "UserRoles",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Auth",
                table: "UserRoles",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "DeletedByID",
                schema: "Auth",
                table: "UserRoles",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Auth",
                table: "UserRoles",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByID",
                schema: "Auth",
                table: "UserRoles",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "Auth",
                table: "UserRoles",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder
                .AddColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FieldSports",
                    type: "integer",
                    nullable: false,
                    defaultValue: 0
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                schema: "Sports",
                table: "FieldSports",
                type: "boolean",
                nullable: false,
                defaultValue: false
            );

            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                schema: "Sports",
                table: "FieldSports",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Sports",
                table: "FieldSports",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "DeletedByID",
                schema: "Sports",
                table: "FieldSports",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Sports",
                table: "FieldSports",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByID",
                schema: "Sports",
                table: "FieldSports",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "Sports",
                table: "FieldSports",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder
                .AddColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FacilityAdministrators",
                    type: "integer",
                    nullable: false,
                    defaultValue: 0
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "boolean",
                nullable: false,
                defaultValue: false
            );

            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "integer",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "Sports",
                table: "FacilityAdministrators",
                type: "timestamp with time zone",
                nullable: true
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Auth",
                table: "UserRoles",
                column: "ID"
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldSports",
                schema: "Sports",
                table: "FieldSports",
                column: "ID"
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacilityAdministrators",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "ID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_CreatedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_DeletedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ModifiedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                schema: "Auth",
                table: "UserRoles",
                column: "UserID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_CreatedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_DeletedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_ModifiedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_SportsFieldID",
                schema: "Sports",
                table: "FieldSports",
                column: "SportsFieldID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FacilityAdministrators_CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FacilityAdministrators_DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FacilityAdministrators_ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FacilityAdministrators_SportsFacilityID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "SportsFacilityID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FacilityAdministrators_User_CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "CreatedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FacilityAdministrators_User_DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "DeletedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FacilityAdministrators_User_ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "ModifiedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FieldSports_User_CreatedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "CreatedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FieldSports_User_DeletedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "DeletedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_FieldSports_User_ModifiedByID",
                schema: "Sports",
                table: "FieldSports",
                column: "ModifiedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleID",
                schema: "Auth",
                table: "UserRoles",
                column: "RoleID",
                principalSchema: "Auth",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_CreatedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "CreatedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_DeletedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "DeletedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_ModifiedByID",
                schema: "Auth",
                table: "UserRoles",
                column: "ModifiedByID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserID",
                schema: "Auth",
                table: "UserRoles",
                column: "UserID",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FacilityAdministrators_User_CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_FacilityAdministrators_User_DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_FacilityAdministrators_User_ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_FieldSports_User_CreatedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_FieldSports_User_DeletedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_FieldSports_User_ModifiedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Role_RoleID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_CreatedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_DeletedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_ModifiedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_CreatedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_DeletedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_ModifiedByID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserID",
                schema: "Auth",
                table: "UserRoles"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_FieldSports",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropIndex(
                name: "IX_FieldSports_CreatedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropIndex(
                name: "IX_FieldSports_DeletedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropIndex(
                name: "IX_FieldSports_ModifiedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropIndex(
                name: "IX_FieldSports_SportsFieldID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropPrimaryKey(
                name: "PK_FacilityAdministrators",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropIndex(
                name: "IX_FacilityAdministrators_CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropIndex(
                name: "IX_FacilityAdministrators_DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropIndex(
                name: "IX_FacilityAdministrators_ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropIndex(
                name: "IX_FacilityAdministrators_SportsFacilityID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(name: "ID", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "Active", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "CreatedByID", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "CreatedDate", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "DeletedByID", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "DeletedDate", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "ModifiedByID", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "ModifiedDate", schema: "Auth", table: "UserRoles");

            migrationBuilder.DropColumn(name: "ID", schema: "Sports", table: "FieldSports");

            migrationBuilder.DropColumn(name: "Active", schema: "Sports", table: "FieldSports");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "Sports",
                table: "FieldSports"
            );

            migrationBuilder.DropColumn(
                name: "ID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "Active",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "DeletedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "ModifiedByID",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "Sports",
                table: "FacilityAdministrators"
            );

            migrationBuilder.RenameColumn(
                name: "UserID",
                schema: "Auth",
                table: "UserRoles",
                newName: "UserId"
            );

            migrationBuilder.RenameColumn(
                name: "RoleID",
                schema: "Auth",
                table: "UserRoles",
                newName: "RoleId"
            );

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleID",
                schema: "Auth",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId"
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "Auth",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" }
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_FieldSports",
                schema: "Sports",
                table: "FieldSports",
                columns: new[] { "SportsFieldID", "SportID" }
            );

            migrationBuilder.AddPrimaryKey(
                name: "PK_FacilityAdministrators",
                schema: "Sports",
                table: "FacilityAdministrators",
                columns: new[] { "SportsFacilityID", "UserID" }
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Role_RoleId",
                schema: "Auth",
                table: "UserRoles",
                column: "RoleId",
                principalSchema: "Auth",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade
            );

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserId",
                schema: "Auth",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "Auth",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade
            );
        }
    }
}
