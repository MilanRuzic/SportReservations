using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(name: "Codes");

            migrationBuilder.EnsureSchema(name: "Sports");

            migrationBuilder.EnsureSchema(name: "Auth");

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Auth",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserName = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    FirstName = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    LastName = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Email = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Password = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    PhoneNumber = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: true
                    ),
                    Adress = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: true
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_User_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_User_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CountryCodes",
                schema: "Codes",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CountryCodes_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_CountryCodes_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_CountryCodes_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Auth",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    RoleName = table.Column<string>(
                        type: "character varying(50)",
                        maxLength: 50,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Role_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Role_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Role_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SportCodes",
                schema: "Codes",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SportCodes_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportCodes_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportCodes_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SurfaceCodes",
                schema: "Codes",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfaceCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SurfaceCodes_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SurfaceCodes_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SurfaceCodes_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CityCodes",
                schema: "Codes",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    CountryID = table.Column<int>(type: "integer", nullable: false),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCodes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CityCodes_CountryCodes_CountryID",
                        column: x => x.CountryID,
                        principalSchema: "Codes",
                        principalTable: "CountryCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CityCodes_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_CityCodes_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_CityCodes_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "Auth",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Auth",
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SportsFacility",
                schema: "Sports",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    CityID = table.Column<int>(type: "integer", nullable: false),
                    Adress = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    PhoneNumber = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Longitude = table.Column<decimal>(
                        type: "numeric(9,6)",
                        precision: 9,
                        scale: 6,
                        nullable: true
                    ),
                    Latitude = table.Column<decimal>(
                        type: "numeric(8,6)",
                        precision: 8,
                        scale: 6,
                        nullable: true
                    ),
                    Email = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsFacility", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SportsFacility_CityCodes_CityID",
                        column: x => x.CityID,
                        principalSchema: "Codes",
                        principalTable: "CityCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsFacility_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsFacility_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsFacility_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "FacilityAdministrators",
                schema: "Sports",
                columns: table => new
                {
                    SportsFacilityID = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_FacilityAdministrators",
                        x => new { x.SportsFacilityID, x.UserID }
                    );
                    table.ForeignKey(
                        name: "FK_FacilityAdministrators_SportsFacility_SportsFacilityID",
                        column: x => x.SportsFacilityID,
                        principalSchema: "Sports",
                        principalTable: "SportsFacility",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_FacilityAdministrators_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "SportsField",
                schema: "Sports",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    SportsFacilityID = table.Column<int>(type: "integer", nullable: false),
                    SurfaceID = table.Column<int>(type: "integer", nullable: false),
                    CityID = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Adress = table.Column<string>(
                        type: "character varying(255)",
                        maxLength: 255,
                        nullable: false
                    ),
                    Longitude = table.Column<decimal>(
                        type: "numeric(9,6)",
                        precision: 9,
                        scale: 6,
                        nullable: false
                    ),
                    Latitude = table.Column<decimal>(
                        type: "numeric(8,6)",
                        precision: 8,
                        scale: 6,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsField", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SportsField_CityCodes_CityID",
                        column: x => x.CityID,
                        principalSchema: "Codes",
                        principalTable: "CityCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsField_SportsFacility_SportsFacilityID",
                        column: x => x.SportsFacilityID,
                        principalSchema: "Sports",
                        principalTable: "SportsFacility",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsField_SurfaceCodes_SurfaceID",
                        column: x => x.SurfaceID,
                        principalSchema: "Codes",
                        principalTable: "SurfaceCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsField_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsField_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsField_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "FieldSports",
                schema: "Sports",
                columns: table => new
                {
                    SportsFieldID = table.Column<int>(type: "integer", nullable: false),
                    SportID = table.Column<int>(type: "integer", nullable: false),
                    SportCodesID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldSports", x => new { x.SportsFieldID, x.SportID });
                    table.ForeignKey(
                        name: "FK_FieldSports_SportCodes_SportCodesID",
                        column: x => x.SportCodesID,
                        principalSchema: "Codes",
                        principalTable: "SportCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_FieldSports_SportsField_SportsFieldID",
                        column: x => x.SportsFieldID,
                        principalSchema: "Sports",
                        principalTable: "SportsField",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "Sports",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    SportsFacilityID = table.Column<int>(type: "integer", nullable: true),
                    SportsFieldID = table.Column<int>(type: "integer", nullable: true),
                    Path = table.Column<string>(
                        type: "character varying(500)",
                        maxLength: 500,
                        nullable: false
                    ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Image_SportsFacility_SportsFacilityID",
                        column: x => x.SportsFacilityID,
                        principalSchema: "Sports",
                        principalTable: "SportsFacility",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Image_SportsField_SportsFieldID",
                        column: x => x.SportsFieldID,
                        principalSchema: "Sports",
                        principalTable: "SportsField",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Image_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Image_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_Image_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_CityCodes_CountryID",
                schema: "Codes",
                table: "CityCodes",
                column: "CountryID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CityCodes_CreatedByID",
                schema: "Codes",
                table: "CityCodes",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CityCodes_DeletedByID",
                schema: "Codes",
                table: "CityCodes",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CityCodes_ModifiedByID",
                schema: "Codes",
                table: "CityCodes",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CountryCodes_CreatedByID",
                schema: "Codes",
                table: "CountryCodes",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CountryCodes_DeletedByID",
                schema: "Codes",
                table: "CountryCodes",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CountryCodes_ModifiedByID",
                schema: "Codes",
                table: "CountryCodes",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FacilityAdministrators_UserID",
                schema: "Sports",
                table: "FacilityAdministrators",
                column: "UserID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_SportCodesID",
                schema: "Sports",
                table: "FieldSports",
                column: "SportCodesID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Image_CreatedByID",
                schema: "Sports",
                table: "Image",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Image_DeletedByID",
                schema: "Sports",
                table: "Image",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Image_ModifiedByID",
                schema: "Sports",
                table: "Image",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Image_SportsFacilityID",
                schema: "Sports",
                table: "Image",
                column: "SportsFacilityID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Image_SportsFieldID",
                schema: "Sports",
                table: "Image",
                column: "SportsFieldID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedByID",
                schema: "Auth",
                table: "Role",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Role_DeletedByID",
                schema: "Auth",
                table: "Role",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedByID",
                schema: "Auth",
                table: "Role",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportCodes_CreatedByID",
                schema: "Codes",
                table: "SportCodes",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportCodes_DeletedByID",
                schema: "Codes",
                table: "SportCodes",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportCodes_ModifiedByID",
                schema: "Codes",
                table: "SportCodes",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFacility_CityID",
                schema: "Sports",
                table: "SportsFacility",
                column: "CityID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFacility_CreatedByID",
                schema: "Sports",
                table: "SportsFacility",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFacility_DeletedByID",
                schema: "Sports",
                table: "SportsFacility",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFacility_ModifiedByID",
                schema: "Sports",
                table: "SportsFacility",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_CityID",
                schema: "Sports",
                table: "SportsField",
                column: "CityID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_CreatedByID",
                schema: "Sports",
                table: "SportsField",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_DeletedByID",
                schema: "Sports",
                table: "SportsField",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_ModifiedByID",
                schema: "Sports",
                table: "SportsField",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_SportsFacilityID",
                schema: "Sports",
                table: "SportsField",
                column: "SportsFacilityID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsField_SurfaceID",
                schema: "Sports",
                table: "SportsField",
                column: "SurfaceID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SurfaceCodes_CreatedByID",
                schema: "Codes",
                table: "SurfaceCodes",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SurfaceCodes_DeletedByID",
                schema: "Codes",
                table: "SurfaceCodes",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SurfaceCodes_ModifiedByID",
                schema: "Codes",
                table: "SurfaceCodes",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedByID",
                schema: "Auth",
                table: "User",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_User_DeletedByID",
                schema: "Auth",
                table: "User",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedByID",
                schema: "Auth",
                table: "User",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "Auth",
                table: "UserRoles",
                column: "RoleId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "FacilityAdministrators", schema: "Sports");

            migrationBuilder.DropTable(name: "FieldSports", schema: "Sports");

            migrationBuilder.DropTable(name: "Image", schema: "Sports");

            migrationBuilder.DropTable(name: "UserRoles", schema: "Auth");

            migrationBuilder.DropTable(name: "SportCodes", schema: "Codes");

            migrationBuilder.DropTable(name: "SportsField", schema: "Sports");

            migrationBuilder.DropTable(name: "Role", schema: "Auth");

            migrationBuilder.DropTable(name: "SportsFacility", schema: "Sports");

            migrationBuilder.DropTable(name: "SurfaceCodes", schema: "Codes");

            migrationBuilder.DropTable(name: "CityCodes", schema: "Codes");

            migrationBuilder.DropTable(name: "CountryCodes", schema: "Codes");

            migrationBuilder.DropTable(name: "User", schema: "Auth");
        }
    }
}
