using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA22.P03.Web.Migrations
{
    public partial class redooriginalseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemListings_Items_ItemId",
                table: "ItemListings");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemListings_Listings_ListingId",
                table: "ItemListings");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listings",
                table: "Listings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemListings",
                table: "ItemListings");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Listings",
                newName: "Listing");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameTable(
                name: "ItemListings",
                newName: "ItemListing");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ProductId",
                table: "Item",
                newName: "IX_Item_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemListings_ListingId",
                table: "ItemListing",
                newName: "IX_ItemListing_ListingId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemListings_ItemId",
                table: "ItemListing",
                newName: "IX_ItemListing_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listing",
                table: "Listing",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemListing",
                table: "ItemListing",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Nintendo's retro console loved thoughout the ages", "Nintendo 64" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Donkey Kong 64 cartridge for the N64", "Donkey Kong 64" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Ocarina of Time cartridge for the N64", "Legend of Zelda: Ocarina of Time" });

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Product_ProductId",
                table: "Item",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListing_Item_ItemId",
                table: "ItemListing",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListing_Listing_ListingId",
                table: "ItemListing",
                column: "ListingId",
                principalTable: "Listing",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Product_ProductId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemListing_Item_ItemId",
                table: "ItemListing");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemListing_Listing_ListingId",
                table: "ItemListing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listing",
                table: "Listing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemListing",
                table: "ItemListing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Listing",
                newName: "Listings");

            migrationBuilder.RenameTable(
                name: "ItemListing",
                newName: "ItemListings");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_ItemListing_ListingId",
                table: "ItemListings",
                newName: "IX_ItemListings_ListingId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemListing_ItemId",
                table: "ItemListings",
                newName: "IX_ItemListings_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_ProductId",
                table: "Items",
                newName: "IX_Items_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listings",
                table: "Listings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemListings",
                table: "ItemListings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListings_Items_ItemId",
                table: "ItemListings",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemListings_Listings_ListingId",
                table: "ItemListings",
                column: "ListingId",
                principalTable: "Listings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Products_ProductId",
                table: "Items",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
