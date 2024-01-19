using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdventureLogAPI.Migrations
{
    /// <inheritdoc />
    public partial class ResolvedTableNameIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Characters_CharacterId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesNotes_Pins_PinId",
                table: "NotesNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesNotes_Users_UserId",
                table: "NotesNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotesNotes",
                table: "NotesNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notes",
                table: "Notes");

            migrationBuilder.RenameTable(
                name: "NotesNotes",
                newName: "PinNotes");

            migrationBuilder.RenameTable(
                name: "Notes",
                newName: "CharacterNotes");

            migrationBuilder.RenameIndex(
                name: "IX_NotesNotes_UserId",
                table: "PinNotes",
                newName: "IX_PinNotes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesNotes_PinId",
                table: "PinNotes",
                newName: "IX_PinNotes_PinId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_UserId",
                table: "CharacterNotes",
                newName: "IX_CharacterNotes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_CharacterId",
                table: "CharacterNotes",
                newName: "IX_CharacterNotes_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PinNotes",
                table: "PinNotes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterNotes",
                table: "CharacterNotes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterNotes_Characters_CharacterId",
                table: "CharacterNotes",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterNotes_Users_UserId",
                table: "CharacterNotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PinNotes_Pins_PinId",
                table: "PinNotes",
                column: "PinId",
                principalTable: "Pins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PinNotes_Users_UserId",
                table: "PinNotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterNotes_Characters_CharacterId",
                table: "CharacterNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterNotes_Users_UserId",
                table: "CharacterNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_PinNotes_Pins_PinId",
                table: "PinNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_PinNotes_Users_UserId",
                table: "PinNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PinNotes",
                table: "PinNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterNotes",
                table: "CharacterNotes");

            migrationBuilder.RenameTable(
                name: "PinNotes",
                newName: "NotesNotes");

            migrationBuilder.RenameTable(
                name: "CharacterNotes",
                newName: "Notes");

            migrationBuilder.RenameIndex(
                name: "IX_PinNotes_UserId",
                table: "NotesNotes",
                newName: "IX_NotesNotes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PinNotes_PinId",
                table: "NotesNotes",
                newName: "IX_NotesNotes_PinId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterNotes_UserId",
                table: "Notes",
                newName: "IX_Notes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterNotes_CharacterId",
                table: "Notes",
                newName: "IX_Notes_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotesNotes",
                table: "NotesNotes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notes",
                table: "Notes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Characters_CharacterId",
                table: "Notes",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesNotes_Pins_PinId",
                table: "NotesNotes",
                column: "PinId",
                principalTable: "Pins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesNotes_Users_UserId",
                table: "NotesNotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
