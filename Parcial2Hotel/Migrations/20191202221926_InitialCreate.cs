using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResHotel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerTitle = table.Column<string>(nullable: true),
                    CustomerForenames = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerSurnames = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerDOB = table.Column<DateTime>(nullable: false),
                    CustomerAddressStreet = table.Column<string>(nullable: true),
                    CustomerAddressTown = table.Column<string>(nullable: true),
                    CustomerAddressCountry = table.Column<string>(nullable: true),
                    CustomerAddressPostalCode = table.Column<string>(nullable: true),
                    CustomerHomePhone = table.Column<string>(nullable: true),
                    CustomerWorkPhone = table.Column<string>(nullable: true),
                    CustomerMobilPhone = table.Column<string>(nullable: true),
                    CustomerCustomEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieList",
                columns: table => new
                {
                    FacilityID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityDesc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitieList", x => x.FacilityID);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuestTitle = table.Column<string>(nullable: true),
                    GuestForenames = table.Column<string>(nullable: false),
                    GuestSurnames = table.Column<string>(nullable: false),
                    GuestDOB = table.Column<DateTime>(nullable: false),
                    GuestAddressStreet = table.Column<string>(nullable: true),
                    GuestAddressTown = table.Column<string>(nullable: true),
                    GuestAddressCountry = table.Column<string>(nullable: true),
                    GuestAddressPostaleCode = table.Column<string>(nullable: true),
                    GuestContactPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentMethods = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "RoomBand",
                columns: table => new
                {
                    RoomBandID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BandDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBand", x => x.RoomBandID);
                });

            migrationBuilder.CreateTable(
                name: "RoomPrice",
                columns: table => new
                {
                    RoomPriceID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomPrices = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomPrice", x => x.RoomPriceID);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomTypes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<int>(nullable: false),
                    DateBookingMade = table.Column<DateTime>(nullable: false),
                    TimeBookingMade = table.Column<string>(nullable: true),
                    BookedStartDate = table.Column<DateTime>(nullable: false),
                    BookedEndDate = table.Column<DateTime>(nullable: false),
                    TotalPaymentDueDate = table.Column<DateTime>(nullable: false),
                    TotalPaymentDueAmount = table.Column<int>(nullable: false),
                    TotalPaymentMadeOn = table.Column<DateTime>(nullable: false),
                    BookingComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomTypeID = table.Column<int>(nullable: false),
                    RoomBandID = table.Column<int>(nullable: false),
                    RoomPriceID = table.Column<int>(nullable: false),
                    Floor = table.Column<string>(maxLength: 100, nullable: true),
                    AdditionalNotes = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Room_RoomBand_RoomBandID",
                        column: x => x.RoomBandID,
                        principalTable: "RoomBand",
                        principalColumn: "RoomBandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomPrice_RoomPriceID",
                        column: x => x.RoomPriceID,
                        principalTable: "RoomPrice",
                        principalColumn: "RoomPriceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeID",
                        column: x => x.RoomTypeID,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookingID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    PaymentMethodID = table.Column<int>(nullable: false),
                    PaymentAmount = table.Column<int>(nullable: false),
                    PaymentComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingRoom",
                columns: table => new
                {
                    BookingID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoomID = table.Column<int>(nullable: false),
                    GuestID = table.Column<int>(nullable: false),
                    BookingID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingRoom", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_BookingRoom_Booking_BookingID1",
                        column: x => x.BookingID1,
                        principalTable: "Booking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingRoom_Guest_GuestID",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingRoom_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomFacilitieList",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FacilityID = table.Column<int>(nullable: false),
                    FacilityDetails = table.Column<string>(nullable: true),
                    RoomID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFacilitieList", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_RoomFacilitieList_FacilitieList_FacilityID",
                        column: x => x.FacilityID,
                        principalTable: "FacilitieList",
                        principalColumn: "FacilityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomFacilitieList_Room_RoomID1",
                        column: x => x.RoomID1,
                        principalTable: "Room",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoom_BookingID1",
                table: "BookingRoom",
                column: "BookingID1");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoom_GuestID",
                table: "BookingRoom",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingRoom_RoomID",
                table: "BookingRoom",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_BookingID",
                table: "Payment",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodID",
                table: "Payment",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomBandID",
                table: "Room",
                column: "RoomBandID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomPriceID",
                table: "Room",
                column: "RoomPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeID",
                table: "Room",
                column: "RoomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilitieList_FacilityID",
                table: "RoomFacilitieList",
                column: "FacilityID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomFacilitieList_RoomID1",
                table: "RoomFacilitieList",
                column: "RoomID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingRoom");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "RoomFacilitieList");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "FacilitieList");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "RoomBand");

            migrationBuilder.DropTable(
                name: "RoomPrice");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
