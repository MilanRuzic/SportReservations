using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FieldSportNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "FieldSports", schema: "Sports");

            migrationBuilder.CreateTable(
                name: "SportsFieldRelation",
                schema: "Sports",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    SportsFieldID = table.Column<int>(type: "integer", nullable: false),
                    SportID = table.Column<int>(type: "integer", nullable: false),
                    SportCodesID = table.Column<int>(type: "integer", nullable: false),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
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
                    table.PrimaryKey("PK_SportsFieldRelation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SportsFieldRelation_SportCodes_SportCodesID",
                        column: x => x.SportCodesID,
                        principalSchema: "Codes",
                        principalTable: "SportCodes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsFieldRelation_SportsField_SportsFieldID",
                        column: x => x.SportsFieldID,
                        principalSchema: "Sports",
                        principalTable: "SportsField",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_SportsFieldRelation_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsFieldRelation_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_SportsFieldRelation_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFieldRelation_CreatedByID",
                schema: "Sports",
                table: "SportsFieldRelation",
                column: "CreatedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFieldRelation_DeletedByID",
                schema: "Sports",
                table: "SportsFieldRelation",
                column: "DeletedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFieldRelation_ModifiedByID",
                schema: "Sports",
                table: "SportsFieldRelation",
                column: "ModifiedByID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFieldRelation_SportCodesID",
                schema: "Sports",
                table: "SportsFieldRelation",
                column: "SportCodesID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_SportsFieldRelation_SportsFieldID",
                schema: "Sports",
                table: "SportsFieldRelation",
                column: "SportsFieldID"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "SportsFieldRelation", schema: "Sports");

            migrationBuilder.CreateTable(
                name: "FieldSports",
                schema: "Sports",
                columns: table => new
                {
                    ID = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    CreatedByID = table.Column<int>(type: "integer", nullable: true),
                    DeletedByID = table.Column<int>(type: "integer", nullable: true),
                    ModifiedByID = table.Column<int>(type: "integer", nullable: true),
                    SportCodesID = table.Column<int>(type: "integer", nullable: false),
                    SportsFieldID = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    DeletedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    ModifiedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    SportID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldSports", x => x.ID);
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
                    table.ForeignKey(
                        name: "FK_FieldSports_User_CreatedByID",
                        column: x => x.CreatedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_FieldSports_User_DeletedByID",
                        column: x => x.DeletedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                    table.ForeignKey(
                        name: "FK_FieldSports_User_ModifiedByID",
                        column: x => x.ModifiedByID,
                        principalSchema: "Auth",
                        principalTable: "User",
                        principalColumn: "ID"
                    );
                }
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
                name: "IX_FieldSports_SportCodesID",
                schema: "Sports",
                table: "FieldSports",
                column: "SportCodesID"
            );

            migrationBuilder.CreateIndex(
                name: "IX_FieldSports_SportsFieldID",
                schema: "Sports",
                table: "FieldSports",
                column: "SportsFieldID"
            );
        }
    }
}
