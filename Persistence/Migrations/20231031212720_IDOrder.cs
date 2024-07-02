using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class IDOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "UserRoles",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "User",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "SurfaceCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "SportsField",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "SportsFacility",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "SportCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "Role",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "Image",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FieldSports",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FacilityAdministrators",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "CountryCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "CityCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .Annotation("Relational:ColumnOrder", 1)
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "UserRoles",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "User",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "SurfaceCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "SportsField",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "SportsFacility",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "SportCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Auth",
                    table: "Role",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "Image",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FieldSports",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Sports",
                    table: "FacilityAdministrators",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "CountryCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder
                .AlterColumn<int>(
                    name: "ID",
                    schema: "Codes",
                    table: "CityCodes",
                    type: "integer",
                    nullable: false,
                    oldClrType: typeof(int),
                    oldType: "integer"
                )
                .Annotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation(
                    "Npgsql:ValueGenerationStrategy",
                    NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                )
                .OldAnnotation("Relational:ColumnOrder", 1);
        }
    }
}
