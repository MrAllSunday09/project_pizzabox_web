using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addingprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Toppings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Sizes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "CustomerEntityId",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StoreEntityId",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 1L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kid's", 2.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 2L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Small", 5.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 3L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Medium", 7.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 4L,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Large", 10.99 });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[] { 5L, "X-Large", 15.99 });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 4L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 5L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 6L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 7L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 8L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 9L,
                column: "Price",
                value: 1.5);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: 10L,
                column: "Price",
                value: 1.5);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerEntityId",
                table: "Orders",
                column: "CustomerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerEntityId",
                table: "Orders",
                column: "CustomerEntityId",
                principalTable: "Customers",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerEntityId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "CustomerEntityId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StoreEntityId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Small");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Medium");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Name",
                value: "Large");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: 4L,
                column: "Name",
                value: "X-Large");
        }
    }
}
