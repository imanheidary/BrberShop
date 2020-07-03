using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberShopInfrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cargoTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargoTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "paymentFors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentFors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "paymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "saloons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Manager = table.Column<string>(nullable: true),
                    Latitude = table.Column<decimal>(nullable: false),
                    Longtitude = table.Column<decimal>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    IsWomen = table.Column<bool>(nullable: false),
                    IsMen = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saloons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ForWoman = table.Column<bool>(nullable: false),
                    ForMan = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    time = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "statuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    BirthdateEn = table.Column<DateTime>(nullable: false),
                    BirthDateFa = table.Column<string>(nullable: true),
                    Pic = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    IsBarber = table.Column<bool>(nullable: false),
                    ActiveCode = table.Column<string>(nullable: true),
                    password = table.Column<byte[]>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsWomen = table.Column<bool>(nullable: false),
                    IsAcceptByAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    CargoTypeId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cargos_cargoTypes_CargoTypeId",
                        column: x => x.CargoTypeId,
                        principalTable: "cargoTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saloonPics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaloonId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saloonPics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_saloonPics_saloons_SaloonId",
                        column: x => x.SaloonId,
                        principalTable: "saloons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    DateEn = table.Column<DateTime>(nullable: false),
                    DateFa = table.Column<string>(nullable: true),
                    IsDeliver = table.Column<bool>(nullable: false),
                    DateDeliverEn = table.Column<DateTime>(nullable: false),
                    DateDeliverFa = table.Column<string>(nullable: true),
                    PriceBeforOff = table.Column<int>(nullable: false),
                    OffPrice = table.Column<int>(nullable: false),
                    FinallPrice = table.Column<int>(nullable: false),
                    AddressTodeliver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saloonStylists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    SaloonId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saloonStylists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_saloonStylists_saloons_SaloonId",
                        column: x => x.SaloonId,
                        principalTable: "saloons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saloonStylists_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "serviceStylists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceStylists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_serviceStylists_services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_serviceStylists_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stylistSamples",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stylistSamples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stylistSamples_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stylistTimeSchadules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DateEn = table.Column<DateTime>(nullable: false),
                    DateFa = table.Column<string>(nullable: true),
                    From = table.Column<int>(nullable: false),
                    To = table.Column<int>(nullable: false),
                    IsBooking = table.Column<bool>(nullable: false),
                    IsFinall = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stylistTimeSchadules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stylistTimeSchadules_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cargoComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(nullable: true),
                    CargoId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateEn = table.Column<DateTime>(nullable: false),
                    DateFa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargoComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cargoComments_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cargoComments_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderCargos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderCargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderCargos_cargos_CargoId",
                        column: x => x.CargoId,
                        principalTable: "cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderCargos_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    stylistSchaduleId = table.Column<int>(nullable: false),
                    stylistTimeId = table.Column<int>(nullable: true),
                    statusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bookings_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_statuses_statusId",
                        column: x => x.statusId,
                        principalTable: "statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_stylistTimeSchadules_stylistTimeId",
                        column: x => x.stylistTimeId,
                        principalTable: "stylistTimeSchadules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bookingServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    serviceUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bookingServices_bookings_bookingId",
                        column: x => x.bookingId,
                        principalTable: "bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingServices_serviceStylists_serviceUserId",
                        column: x => x.serviceUserId,
                        principalTable: "serviceStylists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    PriceBeforOff = table.Column<int>(nullable: false),
                    OffPrice = table.Column<int>(nullable: false),
                    PriceAfterOff = table.Column<int>(nullable: false),
                    FinalPrice = table.Column<int>(nullable: false),
                    PaymentPrice = table.Column<int>(nullable: false),
                    PaymentForId = table.Column<int>(nullable: false),
                    PaymentTypeId = table.Column<int>(nullable: false),
                    PaymentDateEn = table.Column<DateTime>(nullable: false),
                    PaymentDateFa = table.Column<string>(nullable: true),
                    PaymentCode = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_payments_paymentFors_PaymentForId",
                        column: x => x.PaymentForId,
                        principalTable: "paymentFors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_paymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "paymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payments_statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_UserId",
                table: "bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_statusId",
                table: "bookings",
                column: "statusId");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_stylistTimeId",
                table: "bookings",
                column: "stylistTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingServices_bookingId",
                table: "bookingServices",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_bookingServices_serviceUserId",
                table: "bookingServices",
                column: "serviceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_cargoComments_CargoId",
                table: "cargoComments",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_cargoComments_UserId",
                table: "cargoComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_cargos_CargoTypeId",
                table: "cargos",
                column: "CargoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orderCargos_CargoId",
                table: "orderCargos",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_orderCargos_OrderId",
                table: "orderCargos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_StatusId",
                table: "orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_BookingId",
                table: "payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_OrderId",
                table: "payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentForId",
                table: "payments",
                column: "PaymentForId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_PaymentTypeId",
                table: "payments",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_StatusId",
                table: "payments",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_saloonPics_SaloonId",
                table: "saloonPics",
                column: "SaloonId");

            migrationBuilder.CreateIndex(
                name: "IX_saloonStylists_SaloonId",
                table: "saloonStylists",
                column: "SaloonId");

            migrationBuilder.CreateIndex(
                name: "IX_saloonStylists_UserId",
                table: "saloonStylists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceStylists_ServiceId",
                table: "serviceStylists",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceStylists_UserId",
                table: "serviceStylists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_stylistSamples_UserId",
                table: "stylistSamples",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_stylistTimeSchadules_UserId",
                table: "stylistTimeSchadules",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingServices");

            migrationBuilder.DropTable(
                name: "cargoComments");

            migrationBuilder.DropTable(
                name: "orderCargos");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "saloonPics");

            migrationBuilder.DropTable(
                name: "saloonStylists");

            migrationBuilder.DropTable(
                name: "stylistSamples");

            migrationBuilder.DropTable(
                name: "serviceStylists");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "paymentFors");

            migrationBuilder.DropTable(
                name: "paymentTypes");

            migrationBuilder.DropTable(
                name: "saloons");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "cargoTypes");

            migrationBuilder.DropTable(
                name: "stylistTimeSchadules");

            migrationBuilder.DropTable(
                name: "statuses");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
