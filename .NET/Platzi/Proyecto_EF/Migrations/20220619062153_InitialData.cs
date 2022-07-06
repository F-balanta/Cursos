using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_EF.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descriptcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("44a9d16c-131b-4402-9522-cc03b1f20530"), null, "Actividades Pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("44a9d16d-131b-4402-9522-cc03b1f20530"), null, "Actividades Personales", 50 });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descriptcion", "FechaCreacion", "PropridadTarea", "Titulo" },
                values: new object[] { new Guid("44a9d16c-131b-4402-9522-cc03b1f20531"), new Guid("44a9d16c-131b-4402-9522-cc03b1f20530"), null, new DateTime(2022, 6, 19, 1, 21, 53, 567, DateTimeKind.Local).AddTicks(1319), 1, "Pago de servicios publicos" });

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descriptcion", "FechaCreacion", "PropridadTarea", "Titulo" },
                values: new object[] { new Guid("44a9d16c-131b-4402-9522-cc03b1f20532"), new Guid("44a9d16d-131b-4402-9522-cc03b1f20530"), null, new DateTime(2022, 6, 19, 1, 21, 53, 567, DateTimeKind.Local).AddTicks(1338), 0, "Terminar de ver pelicula en Netlix" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("44a9d16c-131b-4402-9522-cc03b1f20531"));

            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("44a9d16c-131b-4402-9522-cc03b1f20532"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("44a9d16c-131b-4402-9522-cc03b1f20530"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("44a9d16d-131b-4402-9522-cc03b1f20530"));

            migrationBuilder.AlterColumn<string>(
                name: "Descriptcion",
                table: "Tarea",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
