﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BE_CRUDMascotas.Migrations
{
    public partial class v01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaCracion",
                table: "Mascotas",
                newName: "FechaCreacion");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Mascotas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Mascotas");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Mascotas",
                newName: "FechaCracion");
        }
    }
}
