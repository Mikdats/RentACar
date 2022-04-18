using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyTypes",
                columns: table => new
                {
                    BodyTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    BodyTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypes", x => x.BodyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<byte>(type: "tinyint", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "CarColors",
                columns: table => new
                {
                    CarColorID = table.Column<byte>(type: "tinyint", nullable: false),
                    CarColorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarColors", x => x.CarColorID);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    FuelTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "GearTypes",
                columns: table => new
                {
                    GearTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    GearTypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearTypes", x => x.GearTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<byte>(type: "tinyint", nullable: false),
                    CarColorID = table.Column<byte>(type: "tinyint", nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FuelTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    GearTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    SeatNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    BodyTypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    LuggageVolume = table.Column<short>(type: "smallint", nullable: false),
                    ModelYear = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_BodyTypes_BodyTypeID",
                        column: x => x.BodyTypeID,
                        principalTable: "BodyTypes",
                        principalColumn: "BodyTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_CarColors_CarColorID",
                        column: x => x.CarColorID,
                        principalTable: "CarColors",
                        principalColumn: "CarColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_GearTypes_GearTypeID",
                        column: x => x.GearTypeID,
                        principalTable: "GearTypes",
                        principalColumn: "GearTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BodyTypes",
                columns: new[] { "BodyTypeID", "BodyTypeName" },
                values: new object[,]
                {
                    { (byte)1, "Cabrio" },
                    { (byte)2, "Coupe" },
                    { (byte)3, "Sedan" },
                    { (byte)4, "HB" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[,]
                {
                    { (byte)1, "Fiat" },
                    { (byte)2, "Renault" },
                    { (byte)3, "Mercedes" },
                    { (byte)4, "BMW" }
                });

            migrationBuilder.InsertData(
                table: "CarColors",
                columns: new[] { "CarColorID", "CarColorName" },
                values: new object[,]
                {
                    { (byte)1, "Kırmızı" },
                    { (byte)2, "Beyaz" },
                    { (byte)3, "Sarı" },
                    { (byte)4, "Siyah" },
                    { (byte)5, "Mavi" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "FuelTypeID", "FuelTypeName" },
                values: new object[,]
                {
                    { (byte)1, "Elektrik" },
                    { (byte)2, "Benzin" },
                    { (byte)3, "Dizel" },
                    { (byte)4, "Hibrit" }
                });

            migrationBuilder.InsertData(
                table: "GearTypes",
                columns: new[] { "GearTypeID", "GearTypeName" },
                values: new object[,]
                {
                    { (byte)1, "Otomatik" },
                    { (byte)2, "Manuel" },
                    { (byte)3, "Tiptritonik" },
                    { (byte)4, "Hibrid" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 1, (byte)4, (byte)1, (byte)3, "ATS", (byte)3, (byte)4, (short)2350, (short)2015, (byte)5 },
                    { 2, (byte)2, (byte)3, (byte)1, "SP2", (byte)3, (byte)4, (short)1650, (short)2022, (byte)7 },
                    { 3, (byte)3, (byte)1, (byte)2, "Sedan de Ville", (byte)1, (byte)4, (short)1700, (short)2021, (byte)2 },
                    { 4, (byte)1, (byte)3, (byte)1, "SRX", (byte)3, (byte)1, (short)150, (short)2020, (byte)2 },
                    { 5, (byte)2, (byte)2, (byte)2, "7-Series", (byte)2, (byte)3, (short)2600, (short)2016, (byte)2 },
                    { 6, (byte)1, (byte)2, (byte)5, "Soul", (byte)3, (byte)2, (short)2100, (short)2020, (byte)5 },
                    { 7, (byte)3, (byte)3, (byte)2, "Sedan de Ville", (byte)2, (byte)1, (short)850, (short)2020, (byte)2 },
                    { 8, (byte)4, (byte)4, (byte)1, "New Six", (byte)4, (byte)2, (short)3000, (short)2021, (byte)2 },
                    { 9, (byte)2, (byte)3, (byte)2, "X1", (byte)3, (byte)2, (short)950, (short)2016, (byte)5 },
                    { 10, (byte)1, (byte)1, (byte)1, "i3", (byte)3, (byte)3, (short)3350, (short)2022, (byte)5 },
                    { 11, (byte)4, (byte)3, (byte)2, "Eldorado", (byte)2, (byte)1, (short)3250, (short)2015, (byte)2 },
                    { 12, (byte)1, (byte)4, (byte)1, "Eldorado", (byte)4, (byte)2, (short)950, (short)2018, (byte)5 },
                    { 13, (byte)4, (byte)3, (byte)5, "Rio", (byte)3, (byte)2, (short)800, (short)2022, (byte)7 },
                    { 14, (byte)2, (byte)4, (byte)5, "Series 60 (Sixty Special)", (byte)3, (byte)2, (short)700, (short)2022, (byte)7 },
                    { 15, (byte)3, (byte)3, (byte)2, "Picanto", (byte)3, (byte)3, (short)3300, (short)2022, (byte)5 },
                    { 16, (byte)4, (byte)2, (byte)3, "Escalade", (byte)1, (byte)2, (short)350, (short)2018, (byte)5 },
                    { 17, (byte)4, (byte)4, (byte)2, "Saveiro", (byte)4, (byte)2, (short)1100, (short)2022, (byte)2 },
                    { 18, (byte)1, (byte)2, (byte)5, "7-Series", (byte)2, (byte)1, (short)2100, (short)2019, (byte)2 },
                    { 19, (byte)2, (byte)1, (byte)5, "Venga", (byte)2, (byte)3, (short)2550, (short)2016, (byte)2 },
                    { 20, (byte)3, (byte)3, (byte)3, "Escalade", (byte)1, (byte)3, (short)1800, (short)2021, (byte)7 },
                    { 21, (byte)4, (byte)4, (byte)3, "Sorento", (byte)3, (byte)4, (short)850, (short)2021, (byte)7 },
                    { 22, (byte)1, (byte)1, (byte)3, "Gol", (byte)1, (byte)2, (short)2000, (short)2018, (byte)2 },
                    { 23, (byte)2, (byte)4, (byte)4, "Niro", (byte)2, (byte)3, (short)450, (short)2015, (byte)5 },
                    { 24, (byte)4, (byte)2, (byte)1, "1-Series", (byte)2, (byte)1, (short)1650, (short)2018, (byte)5 },
                    { 25, (byte)1, (byte)4, (byte)2, "Series 60 (Sixty Special)", (byte)2, (byte)1, (short)300, (short)2019, (byte)5 },
                    { 26, (byte)3, (byte)4, (byte)1, "Series 75", (byte)1, (byte)4, (short)1950, (short)2017, (byte)5 },
                    { 27, (byte)1, (byte)3, (byte)5, "X6", (byte)2, (byte)1, (short)700, (short)2019, (byte)2 },
                    { 28, (byte)2, (byte)3, (byte)2, "Picanto", (byte)2, (byte)3, (short)2050, (short)2018, (byte)5 },
                    { 29, (byte)3, (byte)1, (byte)1, "Escalade", (byte)2, (byte)4, (short)2300, (short)2021, (byte)5 },
                    { 30, (byte)2, (byte)2, (byte)4, "Quoris / K9 / K900", (byte)3, (byte)1, (short)1000, (short)2019, (byte)2 },
                    { 31, (byte)2, (byte)4, (byte)1, "Series 62", (byte)1, (byte)2, (short)1350, (short)2022, (byte)5 },
                    { 32, (byte)3, (byte)2, (byte)5, "Pointer", (byte)2, (byte)2, (short)1250, (short)2020, (byte)5 },
                    { 33, (byte)1, (byte)3, (byte)2, "3-Series, M3", (byte)4, (byte)4, (short)250, (short)2021, (byte)5 },
                    { 34, (byte)4, (byte)3, (byte)1, "Cee'd", (byte)4, (byte)1, (short)1100, (short)2016, (byte)5 },
                    { 35, (byte)4, (byte)1, (byte)3, "New Six CS", (byte)2, (byte)1, (short)2550, (short)2022, (byte)2 },
                    { 36, (byte)1, (byte)4, (byte)3, "Eldorado", (byte)2, (byte)3, (short)3200, (short)2018, (byte)5 },
                    { 37, (byte)2, (byte)4, (byte)4, "Fleetwood Limousine", (byte)4, (byte)4, (short)2350, (short)2020, (byte)5 },
                    { 38, (byte)1, (byte)2, (byte)2, "Catera", (byte)1, (byte)4, (short)2900, (short)2020, (byte)2 },
                    { 39, (byte)4, (byte)1, (byte)2, "BLS", (byte)4, (byte)4, (short)300, (short)2016, (byte)7 },
                    { 40, (byte)1, (byte)4, (byte)3, "Series 62", (byte)4, (byte)3, (short)1150, (short)2022, (byte)2 },
                    { 41, (byte)4, (byte)2, (byte)3, "Sephia", (byte)2, (byte)4, (short)1350, (short)2016, (byte)5 },
                    { 42, (byte)1, (byte)2, (byte)4, "Carens", (byte)4, (byte)3, (short)1700, (short)2015, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 43, (byte)4, (byte)1, (byte)1, "501", (byte)3, (byte)1, (short)850, (short)2017, (byte)5 },
                    { 44, (byte)4, (byte)1, (byte)3, "X1", (byte)3, (byte)1, (short)2450, (short)2020, (byte)5 },
                    { 45, (byte)3, (byte)3, (byte)4, "Gol", (byte)3, (byte)3, (short)2150, (short)2022, (byte)5 },
                    { 46, (byte)1, (byte)3, (byte)5, "Voyage", (byte)1, (byte)4, (short)3400, (short)2021, (byte)7 },
                    { 47, (byte)4, (byte)4, (byte)3, "Avella", (byte)1, (byte)3, (short)2800, (short)2016, (byte)7 },
                    { 48, (byte)2, (byte)2, (byte)4, "Series 62", (byte)4, (byte)4, (short)1650, (short)2019, (byte)7 },
                    { 49, (byte)3, (byte)4, (byte)5, "3-Series, M3", (byte)2, (byte)3, (short)1800, (short)2022, (byte)2 },
                    { 50, (byte)4, (byte)3, (byte)3, "CT6", (byte)4, (byte)4, (short)200, (short)2017, (byte)7 },
                    { 51, (byte)2, (byte)4, (byte)4, "Z3, M", (byte)1, (byte)4, (short)1350, (short)2016, (byte)2 },
                    { 52, (byte)2, (byte)3, (byte)2, "Series 75", (byte)2, (byte)3, (short)3300, (short)2020, (byte)7 },
                    { 53, (byte)1, (byte)4, (byte)1, "i8", (byte)4, (byte)1, (short)2000, (short)2017, (byte)5 },
                    { 54, (byte)2, (byte)3, (byte)5, "Opirus / Amanti", (byte)1, (byte)1, (short)2800, (short)2018, (byte)5 },
                    { 55, (byte)4, (byte)1, (byte)4, "Sedan de Ville", (byte)3, (byte)3, (short)2950, (short)2019, (byte)2 },
                    { 56, (byte)2, (byte)1, (byte)5, "Series 60 (Sixty Special)", (byte)2, (byte)2, (short)1350, (short)2020, (byte)2 },
                    { 57, (byte)1, (byte)2, (byte)4, "Carens / Rondo", (byte)3, (byte)1, (short)2400, (short)2021, (byte)2 },
                    { 58, (byte)1, (byte)1, (byte)4, "8-Series", (byte)3, (byte)1, (short)3000, (short)2015, (byte)7 },
                    { 59, (byte)1, (byte)4, (byte)3, "Enterprise", (byte)3, (byte)3, (short)2400, (short)2019, (byte)5 },
                    { 60, (byte)2, (byte)1, (byte)5, "Quoris / K9 / K900", (byte)4, (byte)3, (short)850, (short)2018, (byte)5 },
                    { 61, (byte)2, (byte)2, (byte)2, "Coupe de Ville", (byte)4, (byte)1, (short)2600, (short)2020, (byte)2 },
                    { 62, (byte)3, (byte)2, (byte)1, "Coupe de Ville", (byte)1, (byte)1, (short)2750, (short)2017, (byte)2 },
                    { 63, (byte)3, (byte)3, (byte)1, "5-Series, M5", (byte)2, (byte)3, (short)3100, (short)2018, (byte)5 },
                    { 64, (byte)3, (byte)2, (byte)3, "Series 61", (byte)2, (byte)3, (short)800, (short)2016, (byte)2 },
                    { 65, (byte)4, (byte)4, (byte)5, "Cadenza / K7", (byte)3, (byte)4, (short)1150, (short)2017, (byte)7 },
                    { 66, (byte)1, (byte)3, (byte)2, "Series 60 (Sixty Special)", (byte)1, (byte)4, (short)2200, (short)2018, (byte)7 },
                    { 67, (byte)2, (byte)3, (byte)5, "6-Series, M6", (byte)2, (byte)3, (short)2400, (short)2019, (byte)2 },
                    { 68, (byte)4, (byte)4, (byte)2, "X2", (byte)1, (byte)4, (short)1750, (short)2022, (byte)7 },
                    { 69, (byte)2, (byte)3, (byte)1, "Carens", (byte)4, (byte)4, (short)1850, (short)2021, (byte)7 },
                    { 70, (byte)3, (byte)4, (byte)1, "Series 60 (Sixty Special)", (byte)4, (byte)4, (short)950, (short)2018, (byte)5 },
                    { 71, (byte)4, (byte)1, (byte)3, "Pride", (byte)2, (byte)1, (short)1450, (short)2016, (byte)2 },
                    { 72, (byte)1, (byte)4, (byte)4, "Seville", (byte)3, (byte)1, (short)850, (short)2022, (byte)5 },
                    { 73, (byte)3, (byte)3, (byte)5, "Coupe de Ville", (byte)4, (byte)3, (short)3150, (short)2022, (byte)7 },
                    { 74, (byte)3, (byte)3, (byte)4, "Series 60 (Sixty Special)", (byte)2, (byte)1, (short)350, (short)2022, (byte)2 },
                    { 75, (byte)4, (byte)2, (byte)4, "Logus", (byte)3, (byte)3, (short)3050, (short)2018, (byte)5 },
                    { 76, (byte)2, (byte)4, (byte)5, "Sephia", (byte)2, (byte)1, (short)1050, (short)2017, (byte)2 },
                    { 77, (byte)4, (byte)2, (byte)3, "Eldorado", (byte)2, (byte)4, (short)2250, (short)2016, (byte)5 },
                    { 78, (byte)1, (byte)2, (byte)2, "Bongo", (byte)1, (byte)4, (short)800, (short)2017, (byte)7 },
                    { 79, (byte)4, (byte)3, (byte)1, "M1", (byte)1, (byte)1, (short)600, (short)2015, (byte)5 },
                    { 80, (byte)2, (byte)1, (byte)1, "Carens", (byte)2, (byte)1, (short)2900, (short)2019, (byte)2 },
                    { 81, (byte)4, (byte)2, (byte)1, "Sportage", (byte)1, (byte)3, (short)550, (short)2018, (byte)2 },
                    { 82, (byte)3, (byte)2, (byte)2, "1-Series", (byte)2, (byte)1, (short)3500, (short)2016, (byte)7 },
                    { 83, (byte)1, (byte)3, (byte)4, "6-Series GT", (byte)4, (byte)2, (short)400, (short)2018, (byte)2 },
                    { 84, (byte)1, (byte)4, (byte)2, "Quoris / K9 / K900", (byte)1, (byte)2, (short)900, (short)2016, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 85, (byte)3, (byte)2, (byte)5, "X5", (byte)4, (byte)2, (short)2900, (short)2019, (byte)7 },
                    { 86, (byte)1, (byte)1, (byte)2, "Sedan de Ville", (byte)1, (byte)3, (short)1450, (short)2022, (byte)7 },
                    { 87, (byte)1, (byte)1, (byte)5, "Enterprise", (byte)1, (byte)4, (short)1650, (short)2020, (byte)2 },
                    { 88, (byte)1, (byte)4, (byte)2, "Rio", (byte)3, (byte)4, (short)2150, (short)2021, (byte)7 },
                    { 89, (byte)1, (byte)3, (byte)3, "Soul", (byte)4, (byte)3, (short)850, (short)2022, (byte)2 },
                    { 90, (byte)2, (byte)4, (byte)4, "CTS", (byte)3, (byte)2, (short)2800, (short)2019, (byte)7 },
                    { 91, (byte)4, (byte)2, (byte)2, "Saveiro", (byte)3, (byte)4, (short)650, (short)2020, (byte)5 },
                    { 92, (byte)4, (byte)3, (byte)2, "Series 62", (byte)3, (byte)3, (short)2100, (short)2015, (byte)5 },
                    { 93, (byte)2, (byte)1, (byte)4, "XTS", (byte)1, (byte)3, (short)2000, (short)2018, (byte)7 },
                    { 94, (byte)4, (byte)1, (byte)2, "Avella", (byte)4, (byte)2, (short)1750, (short)2019, (byte)5 },
                    { 95, (byte)2, (byte)3, (byte)3, "SpaceFox / Suran / SportVan / Fox Plus", (byte)2, (byte)1, (short)1550, (short)2015, (byte)5 },
                    { 96, (byte)1, (byte)2, (byte)5, "Sportage", (byte)1, (byte)4, (short)350, (short)2021, (byte)5 },
                    { 97, (byte)3, (byte)1, (byte)2, "X5", (byte)1, (byte)4, (short)1400, (short)2015, (byte)5 },
                    { 98, (byte)3, (byte)4, (byte)2, "502", (byte)1, (byte)1, (short)1700, (short)2015, (byte)5 },
                    { 99, (byte)3, (byte)1, (byte)5, "New Class 1500, 1600, 1800, 2000", (byte)1, (byte)3, (short)1050, (short)2016, (byte)7 },
                    { 100, (byte)3, (byte)1, (byte)5, "Eldorado", (byte)2, (byte)1, (short)1300, (short)2015, (byte)2 },
                    { 101, (byte)4, (byte)1, (byte)2, "M1", (byte)2, (byte)2, (short)2450, (short)2021, (byte)5 },
                    { 102, (byte)2, (byte)3, (byte)3, "Escalade", (byte)3, (byte)4, (short)1700, (short)2020, (byte)2 },
                    { 103, (byte)1, (byte)3, (byte)2, "Series 75", (byte)2, (byte)4, (short)1800, (short)2018, (byte)5 },
                    { 104, (byte)4, (byte)3, (byte)5, "Seville", (byte)2, (byte)3, (short)1050, (short)2017, (byte)5 },
                    { 105, (byte)4, (byte)2, (byte)5, "Rio", (byte)3, (byte)1, (short)2700, (short)2019, (byte)5 },
                    { 106, (byte)4, (byte)4, (byte)2, "Fleetwood Limousine", (byte)4, (byte)2, (short)2500, (short)2021, (byte)2 },
                    { 107, (byte)1, (byte)4, (byte)5, "6-Series, M6", (byte)3, (byte)2, (short)1850, (short)2019, (byte)2 },
                    { 108, (byte)3, (byte)1, (byte)2, "5-Series, M5", (byte)3, (byte)1, (short)350, (short)2022, (byte)5 },
                    { 109, (byte)2, (byte)1, (byte)3, "Series 60", (byte)1, (byte)1, (short)1750, (short)2021, (byte)7 },
                    { 110, (byte)4, (byte)4, (byte)2, "Coupe de Ville", (byte)1, (byte)4, (short)3350, (short)2020, (byte)5 },
                    { 111, (byte)4, (byte)3, (byte)5, "Carens / Rondo", (byte)3, (byte)2, (short)2150, (short)2021, (byte)5 },
                    { 112, (byte)1, (byte)4, (byte)1, "3-Series, M3", (byte)3, (byte)3, (short)2600, (short)2022, (byte)7 },
                    { 113, (byte)4, (byte)1, (byte)2, "Magentis / Optima", (byte)2, (byte)2, (short)850, (short)2018, (byte)7 },
                    { 114, (byte)4, (byte)1, (byte)5, "Seville", (byte)3, (byte)1, (short)2650, (short)2015, (byte)5 },
                    { 115, (byte)3, (byte)3, (byte)4, "Sedan de Ville", (byte)2, (byte)2, (short)2300, (short)2017, (byte)7 },
                    { 116, (byte)1, (byte)2, (byte)1, "Seville", (byte)2, (byte)1, (short)2850, (short)2021, (byte)5 },
                    { 117, (byte)2, (byte)1, (byte)3, "Carens", (byte)3, (byte)4, (short)1400, (short)2015, (byte)7 },
                    { 118, (byte)1, (byte)3, (byte)5, "4-Series, M4", (byte)2, (byte)1, (short)2250, (short)2018, (byte)5 },
                    { 119, (byte)2, (byte)4, (byte)4, "Z8", (byte)1, (byte)1, (short)3400, (short)2019, (byte)5 },
                    { 120, (byte)4, (byte)4, (byte)4, "Bongo", (byte)1, (byte)1, (short)1850, (short)2016, (byte)7 },
                    { 121, (byte)3, (byte)4, (byte)2, "Coupe de Ville", (byte)4, (byte)4, (short)1700, (short)2015, (byte)5 },
                    { 122, (byte)2, (byte)4, (byte)3, "Cee'd", (byte)3, (byte)1, (short)2200, (short)2021, (byte)5 },
                    { 123, (byte)2, (byte)1, (byte)1, "Allanté", (byte)2, (byte)3, (short)600, (short)2018, (byte)7 },
                    { 124, (byte)3, (byte)1, (byte)2, "Series 60 (Sixty Special)", (byte)2, (byte)2, (short)1850, (short)2017, (byte)7 },
                    { 125, (byte)1, (byte)2, (byte)5, "Sedan de Ville", (byte)1, (byte)4, (short)2300, (short)2021, (byte)2 },
                    { 126, (byte)2, (byte)2, (byte)3, "Santana", (byte)4, (byte)1, (short)3150, (short)2019, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 127, (byte)1, (byte)2, (byte)1, "SRX", (byte)2, (byte)3, (short)2550, (short)2019, (byte)2 },
                    { 128, (byte)1, (byte)2, (byte)4, "Clarus", (byte)1, (byte)2, (short)1700, (short)2021, (byte)2 },
                    { 129, (byte)4, (byte)1, (byte)1, "Seville", (byte)3, (byte)2, (short)3350, (short)2021, (byte)7 },
                    { 130, (byte)1, (byte)4, (byte)5, "XT4", (byte)2, (byte)2, (short)2750, (short)2016, (byte)7 },
                    { 131, (byte)3, (byte)2, (byte)1, "New Six CS", (byte)1, (byte)3, (short)2000, (short)2017, (byte)5 },
                    { 132, (byte)4, (byte)3, (byte)4, "Escalade", (byte)4, (byte)3, (short)2850, (short)2020, (byte)5 },
                    { 133, (byte)3, (byte)2, (byte)4, "5-Series, M5", (byte)4, (byte)2, (short)2550, (short)2021, (byte)7 },
                    { 134, (byte)3, (byte)2, (byte)3, "X4", (byte)1, (byte)2, (short)1100, (short)2019, (byte)7 },
                    { 135, (byte)3, (byte)2, (byte)2, "X6", (byte)2, (byte)1, (short)3450, (short)2018, (byte)2 },
                    { 136, (byte)1, (byte)3, (byte)5, "Coupe de Ville", (byte)2, (byte)1, (short)1100, (short)2015, (byte)2 },
                    { 137, (byte)4, (byte)3, (byte)1, "Parati", (byte)4, (byte)4, (short)450, (short)2020, (byte)5 },
                    { 138, (byte)3, (byte)4, (byte)2, "Coupe de Ville", (byte)3, (byte)3, (short)350, (short)2016, (byte)5 },
                    { 139, (byte)2, (byte)2, (byte)1, "Rio", (byte)2, (byte)1, (short)1900, (short)2017, (byte)5 },
                    { 140, (byte)1, (byte)1, (byte)3, "CT6", (byte)1, (byte)3, (short)350, (short)2020, (byte)7 },
                    { 141, (byte)3, (byte)1, (byte)2, "7-Series", (byte)1, (byte)4, (short)1450, (short)2022, (byte)2 },
                    { 142, (byte)1, (byte)4, (byte)2, "3-Series, M3", (byte)4, (byte)1, (short)700, (short)2018, (byte)5 },
                    { 143, (byte)3, (byte)4, (byte)1, "Picanto", (byte)2, (byte)2, (short)1150, (short)2019, (byte)7 },
                    { 144, (byte)2, (byte)4, (byte)5, "SRX", (byte)1, (byte)2, (short)1600, (short)2017, (byte)2 },
                    { 145, (byte)2, (byte)2, (byte)4, "Retona", (byte)2, (byte)4, (short)2800, (short)2021, (byte)7 },
                    { 146, (byte)2, (byte)1, (byte)3, "Series 61", (byte)2, (byte)1, (short)600, (short)2022, (byte)5 },
                    { 147, (byte)3, (byte)4, (byte)3, "Venga", (byte)1, (byte)4, (short)300, (short)2015, (byte)2 },
                    { 148, (byte)1, (byte)2, (byte)5, "Cadenza / K7", (byte)2, (byte)1, (short)3400, (short)2020, (byte)7 },
                    { 149, (byte)3, (byte)4, (byte)2, "3-Series, M3", (byte)3, (byte)2, (short)1500, (short)2022, (byte)7 },
                    { 150, (byte)1, (byte)1, (byte)5, "Enterprise", (byte)4, (byte)3, (short)2400, (short)2016, (byte)7 },
                    { 151, (byte)2, (byte)3, (byte)2, "New Class 1500, 1600, 1800, 2000", (byte)1, (byte)4, (short)200, (short)2016, (byte)5 },
                    { 152, (byte)3, (byte)4, (byte)3, "Z8", (byte)2, (byte)2, (short)2000, (short)2015, (byte)5 },
                    { 153, (byte)4, (byte)3, (byte)5, "507", (byte)4, (byte)4, (short)2850, (short)2018, (byte)7 },
                    { 154, (byte)4, (byte)3, (byte)4, "Eldorado", (byte)3, (byte)4, (short)2700, (short)2016, (byte)7 },
                    { 155, (byte)1, (byte)4, (byte)1, "DTS", (byte)2, (byte)1, (short)3200, (short)2017, (byte)7 },
                    { 156, (byte)3, (byte)4, (byte)2, "Fusca", (byte)1, (byte)3, (short)1850, (short)2018, (byte)5 },
                    { 157, (byte)4, (byte)4, (byte)5, "Potentia", (byte)4, (byte)4, (short)350, (short)2022, (byte)7 },
                    { 158, (byte)3, (byte)3, (byte)5, "Sephia", (byte)3, (byte)1, (short)3300, (short)2018, (byte)5 },
                    { 159, (byte)1, (byte)3, (byte)1, "Series 75", (byte)3, (byte)2, (short)2000, (short)2018, (byte)2 },
                    { 160, (byte)2, (byte)2, (byte)1, "ATS", (byte)3, (byte)1, (short)1550, (short)2022, (byte)2 },
                    { 161, (byte)1, (byte)4, (byte)5, "Retona", (byte)2, (byte)2, (short)1250, (short)2018, (byte)2 },
                    { 162, (byte)1, (byte)1, (byte)5, "CTS", (byte)3, (byte)3, (short)1500, (short)2019, (byte)5 },
                    { 163, (byte)4, (byte)3, (byte)5, "Sportage", (byte)2, (byte)4, (short)1600, (short)2018, (byte)2 },
                    { 164, (byte)4, (byte)3, (byte)2, "7-Series", (byte)4, (byte)2, (short)2000, (short)2019, (byte)2 },
                    { 165, (byte)4, (byte)4, (byte)5, "M1", (byte)2, (byte)2, (short)2900, (short)2022, (byte)7 },
                    { 166, (byte)1, (byte)4, (byte)5, "Fleetwood Brougham", (byte)4, (byte)2, (short)1200, (short)2018, (byte)2 },
                    { 167, (byte)2, (byte)3, (byte)3, "Series 60 (Sixty Special)", (byte)2, (byte)2, (short)150, (short)2018, (byte)2 },
                    { 168, (byte)3, (byte)3, (byte)4, "X5", (byte)1, (byte)2, (short)850, (short)2021, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 169, (byte)1, (byte)2, (byte)3, "Eldorado", (byte)1, (byte)3, (short)2650, (short)2016, (byte)5 },
                    { 170, (byte)2, (byte)4, (byte)1, "Sedan de Ville", (byte)1, (byte)4, (short)3150, (short)2020, (byte)5 },
                    { 171, (byte)3, (byte)4, (byte)5, "Eldorado", (byte)2, (byte)3, (short)3250, (short)2016, (byte)2 },
                    { 172, (byte)2, (byte)4, (byte)4, "Parati", (byte)1, (byte)2, (short)1000, (short)2015, (byte)7 },
                    { 173, (byte)1, (byte)4, (byte)2, "1-Series", (byte)4, (byte)1, (short)450, (short)2017, (byte)7 },
                    { 174, (byte)1, (byte)3, (byte)4, "5-Series, M5", (byte)2, (byte)1, (short)1100, (short)2015, (byte)5 },
                    { 175, (byte)2, (byte)3, (byte)4, "X3", (byte)4, (byte)1, (short)2000, (short)2020, (byte)5 },
                    { 176, (byte)1, (byte)2, (byte)1, "Sedan de Ville", (byte)3, (byte)2, (short)150, (short)2015, (byte)7 },
                    { 177, (byte)3, (byte)1, (byte)2, "Escalade", (byte)1, (byte)3, (short)1300, (short)2016, (byte)5 },
                    { 178, (byte)1, (byte)3, (byte)4, "XTS", (byte)4, (byte)2, (short)2000, (short)2021, (byte)5 },
                    { 179, (byte)3, (byte)1, (byte)4, "Carens", (byte)4, (byte)1, (short)1700, (short)2022, (byte)2 },
                    { 180, (byte)2, (byte)4, (byte)1, "1-Series", (byte)4, (byte)2, (short)3000, (short)2016, (byte)7 },
                    { 181, (byte)4, (byte)1, (byte)3, "3-Series GT", (byte)3, (byte)4, (short)1900, (short)2017, (byte)5 },
                    { 182, (byte)2, (byte)4, (byte)1, "Escalade", (byte)1, (byte)4, (short)150, (short)2018, (byte)5 },
                    { 183, (byte)4, (byte)1, (byte)4, "Clarus", (byte)3, (byte)3, (short)1850, (short)2022, (byte)5 },
                    { 184, (byte)2, (byte)1, (byte)4, "Series 60 (Sixty Special)", (byte)2, (byte)4, (short)2700, (short)2019, (byte)5 },
                    { 185, (byte)4, (byte)3, (byte)1, "Soul", (byte)4, (byte)3, (short)550, (short)2020, (byte)7 },
                    { 186, (byte)1, (byte)1, (byte)4, "New Class 1500, 1600, 1800, 2000", (byte)4, (byte)1, (short)3100, (short)2019, (byte)5 },
                    { 187, (byte)2, (byte)3, (byte)4, "Series 61", (byte)2, (byte)1, (short)2750, (short)2018, (byte)5 },
                    { 188, (byte)4, (byte)2, (byte)1, "Avella", (byte)4, (byte)2, (short)1800, (short)2016, (byte)5 },
                    { 189, (byte)3, (byte)2, (byte)3, "X5", (byte)1, (byte)2, (short)350, (short)2017, (byte)5 },
                    { 190, (byte)4, (byte)3, (byte)3, "Series 62", (byte)2, (byte)1, (short)2100, (short)2018, (byte)2 },
                    { 191, (byte)2, (byte)2, (byte)3, "XTS", (byte)3, (byte)2, (short)400, (short)2015, (byte)7 },
                    { 192, (byte)1, (byte)1, (byte)3, "Sedan de Ville", (byte)2, (byte)4, (short)2700, (short)2020, (byte)7 },
                    { 193, (byte)1, (byte)3, (byte)5, "Sephia", (byte)1, (byte)4, (short)3200, (short)2016, (byte)2 },
                    { 194, (byte)2, (byte)2, (byte)1, "Series 60 (Sixty Special)", (byte)3, (byte)3, (short)3400, (short)2022, (byte)5 },
                    { 195, (byte)4, (byte)1, (byte)4, "X7", (byte)4, (byte)3, (short)1700, (short)2022, (byte)7 },
                    { 196, (byte)4, (byte)1, (byte)5, "Fleetwood", (byte)2, (byte)4, (short)600, (short)2018, (byte)7 },
                    { 197, (byte)3, (byte)2, (byte)3, "Fox", (byte)3, (byte)3, (short)2300, (short)2021, (byte)5 },
                    { 198, (byte)1, (byte)2, (byte)2, "Carnival / Sedona", (byte)2, (byte)4, (short)3150, (short)2021, (byte)2 },
                    { 199, (byte)4, (byte)1, (byte)5, "Series 61", (byte)1, (byte)4, (short)2900, (short)2021, (byte)7 },
                    { 200, (byte)1, (byte)2, (byte)2, "3-Series, M3", (byte)4, (byte)1, (short)2200, (short)2020, (byte)2 },
                    { 201, (byte)3, (byte)2, (byte)2, "6-Series, M6", (byte)4, (byte)3, (short)3200, (short)2016, (byte)7 },
                    { 202, (byte)1, (byte)1, (byte)3, "Fleetwood Limousine", (byte)1, (byte)1, (short)2600, (short)2015, (byte)2 },
                    { 203, (byte)4, (byte)3, (byte)3, "Series 60 (Sixty Special)", (byte)2, (byte)3, (short)2300, (short)2017, (byte)5 },
                    { 204, (byte)1, (byte)2, (byte)2, "X3", (byte)4, (byte)1, (short)3300, (short)2018, (byte)5 },
                    { 205, (byte)3, (byte)3, (byte)3, "Venga", (byte)1, (byte)1, (short)2550, (short)2020, (byte)2 },
                    { 206, (byte)4, (byte)2, (byte)5, "CTS", (byte)2, (byte)2, (short)2000, (short)2018, (byte)7 },
                    { 207, (byte)4, (byte)1, (byte)1, "Magentis / Optima / K5", (byte)4, (byte)4, (short)750, (short)2020, (byte)7 },
                    { 208, (byte)1, (byte)1, (byte)5, "5-Series GT", (byte)1, (byte)4, (short)2250, (short)2015, (byte)5 },
                    { 209, (byte)4, (byte)1, (byte)2, "New Six CS", (byte)4, (byte)3, (short)2200, (short)2017, (byte)2 },
                    { 210, (byte)4, (byte)4, (byte)1, "Sportage", (byte)3, (byte)1, (short)3300, (short)2022, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 211, (byte)3, (byte)2, (byte)5, "Eldorado", (byte)1, (byte)2, (short)1200, (short)2020, (byte)5 },
                    { 212, (byte)3, (byte)2, (byte)3, "Fleetwood 75", (byte)1, (byte)4, (short)2450, (short)2017, (byte)7 },
                    { 213, (byte)4, (byte)1, (byte)5, "Eldorado", (byte)2, (byte)4, (short)2050, (short)2020, (byte)2 },
                    { 214, (byte)3, (byte)1, (byte)4, "Joice", (byte)4, (byte)4, (short)1350, (short)2020, (byte)2 },
                    { 215, (byte)1, (byte)2, (byte)3, "Carens / Rondo", (byte)4, (byte)3, (short)3100, (short)2019, (byte)2 },
                    { 216, (byte)4, (byte)3, (byte)2, "7-Series", (byte)2, (byte)1, (short)3050, (short)2015, (byte)2 },
                    { 217, (byte)3, (byte)1, (byte)3, "Cadenza / K7", (byte)2, (byte)3, (short)3500, (short)2017, (byte)5 },
                    { 218, (byte)3, (byte)3, (byte)1, "Seville", (byte)2, (byte)2, (short)700, (short)2022, (byte)7 },
                    { 219, (byte)2, (byte)3, (byte)3, "Seville", (byte)2, (byte)1, (short)2000, (short)2022, (byte)7 },
                    { 220, (byte)2, (byte)2, (byte)4, "Apollo", (byte)2, (byte)4, (short)2550, (short)2020, (byte)7 },
                    { 221, (byte)1, (byte)2, (byte)4, "3-Series, M3", (byte)3, (byte)2, (short)2700, (short)2019, (byte)2 },
                    { 222, (byte)1, (byte)3, (byte)3, "Fox", (byte)2, (byte)1, (short)1100, (short)2021, (byte)7 },
                    { 223, (byte)2, (byte)4, (byte)2, "Sephia", (byte)4, (byte)2, (short)1250, (short)2017, (byte)2 },
                    { 224, (byte)1, (byte)4, (byte)1, "Seville", (byte)2, (byte)1, (short)2600, (short)2015, (byte)2 },
                    { 225, (byte)4, (byte)3, (byte)1, "ATS", (byte)4, (byte)3, (short)200, (short)2018, (byte)7 },
                    { 226, (byte)3, (byte)4, (byte)2, "5-Series, M5", (byte)3, (byte)4, (short)750, (short)2021, (byte)5 },
                    { 227, (byte)2, (byte)1, (byte)1, "Seville", (byte)4, (byte)4, (short)250, (short)2015, (byte)5 },
                    { 228, (byte)2, (byte)4, (byte)3, "5-Series, M5", (byte)2, (byte)3, (short)2450, (short)2021, (byte)2 },
                    { 229, (byte)4, (byte)1, (byte)5, "Gol", (byte)1, (byte)2, (short)1800, (short)2021, (byte)7 },
                    { 230, (byte)3, (byte)3, (byte)1, "Series 60 (Sixty Special)", (byte)2, (byte)3, (short)2700, (short)2018, (byte)7 },
                    { 231, (byte)3, (byte)3, (byte)2, "New Class 1500, 1600, 1800, 2000", (byte)2, (byte)1, (short)1450, (short)2021, (byte)2 },
                    { 232, (byte)4, (byte)2, (byte)3, "DTS", (byte)1, (byte)2, (short)2350, (short)2022, (byte)2 },
                    { 233, (byte)1, (byte)3, (byte)5, "507", (byte)2, (byte)1, (short)1550, (short)2019, (byte)5 },
                    { 234, (byte)1, (byte)1, (byte)2, "Carnival / Sedona", (byte)3, (byte)3, (short)1300, (short)2016, (byte)2 },
                    { 235, (byte)1, (byte)4, (byte)1, "5-Series, M5", (byte)1, (byte)1, (short)1800, (short)2017, (byte)5 },
                    { 236, (byte)1, (byte)2, (byte)5, "Eldorado", (byte)3, (byte)3, (short)2100, (short)2019, (byte)2 },
                    { 237, (byte)1, (byte)4, (byte)3, "Fleetwood Limousine", (byte)2, (byte)3, (short)3400, (short)2021, (byte)7 },
                    { 238, (byte)1, (byte)3, (byte)3, "7-Series", (byte)2, (byte)2, (short)1700, (short)2020, (byte)5 },
                    { 239, (byte)4, (byte)4, (byte)2, "Voyage", (byte)4, (byte)3, (short)2850, (short)2016, (byte)7 },
                    { 240, (byte)3, (byte)2, (byte)1, "Carens / Rondo", (byte)4, (byte)4, (short)1800, (short)2022, (byte)5 },
                    { 241, (byte)1, (byte)4, (byte)3, "7-Series", (byte)4, (byte)1, (short)2400, (short)2021, (byte)5 },
                    { 242, (byte)2, (byte)4, (byte)2, "Santana", (byte)3, (byte)3, (short)2700, (short)2020, (byte)7 },
                    { 243, (byte)1, (byte)4, (byte)3, "Bongo Frontier", (byte)4, (byte)4, (short)200, (short)2015, (byte)7 },
                    { 244, (byte)3, (byte)1, (byte)1, "Series 62", (byte)1, (byte)2, (short)2450, (short)2022, (byte)7 },
                    { 245, (byte)4, (byte)4, (byte)4, "3-Series GT", (byte)1, (byte)4, (short)2000, (short)2020, (byte)5 },
                    { 246, (byte)1, (byte)1, (byte)3, "X7", (byte)2, (byte)1, (short)2100, (short)2022, (byte)5 },
                    { 247, (byte)2, (byte)4, (byte)3, "Fleetwood Brougham", (byte)2, (byte)1, (short)1750, (short)2019, (byte)7 },
                    { 248, (byte)4, (byte)3, (byte)5, "Avella", (byte)4, (byte)1, (short)2650, (short)2022, (byte)5 },
                    { 249, (byte)4, (byte)2, (byte)3, "Magentis / Optima / K5", (byte)1, (byte)3, (short)1250, (short)2022, (byte)7 },
                    { 250, (byte)1, (byte)2, (byte)2, "CTS", (byte)4, (byte)3, (short)1650, (short)2020, (byte)7 },
                    { 251, (byte)1, (byte)2, (byte)2, "7-Series", (byte)3, (byte)1, (short)300, (short)2021, (byte)2 },
                    { 252, (byte)4, (byte)3, (byte)4, "3-Series", (byte)2, (byte)1, (short)2750, (short)2019, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 253, (byte)2, (byte)1, (byte)4, "Series 60 (Sixty Special)", (byte)4, (byte)2, (short)2550, (short)2019, (byte)2 },
                    { 254, (byte)4, (byte)1, (byte)2, "X5", (byte)2, (byte)3, (short)550, (short)2020, (byte)2 },
                    { 255, (byte)3, (byte)1, (byte)3, "Calais", (byte)2, (byte)1, (short)2550, (short)2017, (byte)7 },
                    { 256, (byte)3, (byte)4, (byte)1, "Picanto", (byte)4, (byte)2, (short)1700, (short)2017, (byte)2 },
                    { 257, (byte)1, (byte)1, (byte)1, "X2", (byte)4, (byte)2, (short)3000, (short)2018, (byte)7 },
                    { 258, (byte)2, (byte)3, (byte)4, "Series 60 (Sixty Special)", (byte)3, (byte)1, (short)1450, (short)2019, (byte)5 },
                    { 259, (byte)4, (byte)1, (byte)4, "6-Series, M6", (byte)3, (byte)1, (short)1250, (short)2020, (byte)5 },
                    { 260, (byte)2, (byte)3, (byte)5, "Sportage", (byte)3, (byte)2, (short)800, (short)2021, (byte)7 },
                    { 261, (byte)1, (byte)3, (byte)2, "Series 60 (Sixty Special)", (byte)1, (byte)4, (short)600, (short)2020, (byte)2 },
                    { 262, (byte)1, (byte)2, (byte)2, "New Class 1602, 1802, 2002", (byte)1, (byte)1, (short)2500, (short)2021, (byte)2 },
                    { 263, (byte)3, (byte)3, (byte)5, "8-Series", (byte)3, (byte)2, (short)3250, (short)2017, (byte)2 },
                    { 264, (byte)2, (byte)4, (byte)3, "BLS", (byte)2, (byte)1, (short)1750, (short)2017, (byte)5 },
                    { 265, (byte)4, (byte)2, (byte)1, "Series 75", (byte)2, (byte)4, (short)2750, (short)2015, (byte)7 },
                    { 266, (byte)2, (byte)3, (byte)3, "Opirus / Amanti", (byte)2, (byte)3, (short)1600, (short)2017, (byte)7 },
                    { 267, (byte)3, (byte)1, (byte)2, "5-Series, M5", (byte)4, (byte)2, (short)1300, (short)2017, (byte)7 },
                    { 268, (byte)3, (byte)3, (byte)5, "Eldorado", (byte)1, (byte)3, (short)700, (short)2019, (byte)7 },
                    { 269, (byte)1, (byte)3, (byte)5, "Fleetwood", (byte)3, (byte)1, (short)400, (short)2018, (byte)2 },
                    { 270, (byte)2, (byte)2, (byte)5, "Z3, M", (byte)4, (byte)1, (short)400, (short)2019, (byte)2 },
                    { 271, (byte)1, (byte)2, (byte)5, "Eldorado", (byte)2, (byte)2, (short)500, (short)2018, (byte)5 },
                    { 272, (byte)2, (byte)2, (byte)1, "STS", (byte)4, (byte)1, (short)3100, (short)2015, (byte)2 },
                    { 273, (byte)1, (byte)2, (byte)1, "Picanto", (byte)3, (byte)4, (short)2600, (short)2017, (byte)5 },
                    { 274, (byte)3, (byte)4, (byte)1, "Forte / K3", (byte)1, (byte)2, (short)1300, (short)2022, (byte)5 },
                    { 275, (byte)4, (byte)1, (byte)4, "Series 75", (byte)3, (byte)3, (short)3500, (short)2019, (byte)7 },
                    { 276, (byte)4, (byte)1, (byte)1, "Eldorado", (byte)3, (byte)2, (short)2950, (short)2022, (byte)2 },
                    { 277, (byte)1, (byte)4, (byte)2, "Magentis / Optima / K5", (byte)1, (byte)2, (short)3400, (short)2020, (byte)5 },
                    { 278, (byte)1, (byte)3, (byte)2, "Coupe de Ville", (byte)2, (byte)4, (short)1300, (short)2021, (byte)5 },
                    { 279, (byte)3, (byte)4, (byte)5, "Sorento", (byte)2, (byte)3, (short)300, (short)2020, (byte)5 },
                    { 280, (byte)2, (byte)3, (byte)5, "Series 61", (byte)1, (byte)3, (short)200, (short)2019, (byte)7 },
                    { 281, (byte)4, (byte)3, (byte)5, "Concord", (byte)1, (byte)2, (short)2400, (short)2022, (byte)5 },
                    { 282, (byte)1, (byte)1, (byte)4, "Soul", (byte)3, (byte)2, (short)1900, (short)2021, (byte)2 },
                    { 283, (byte)1, (byte)4, (byte)1, "1-Series", (byte)1, (byte)2, (short)2900, (short)2016, (byte)7 },
                    { 284, (byte)1, (byte)2, (byte)2, "Series 60 (Sixty Special)", (byte)3, (byte)2, (short)2550, (short)2021, (byte)2 },
                    { 285, (byte)2, (byte)1, (byte)1, "7-Series", (byte)3, (byte)4, (short)3000, (short)2019, (byte)5 },
                    { 286, (byte)1, (byte)2, (byte)2, "Bongo", (byte)2, (byte)2, (short)3100, (short)2016, (byte)5 },
                    { 287, (byte)3, (byte)3, (byte)2, "Cimarron", (byte)3, (byte)2, (short)2550, (short)2019, (byte)7 },
                    { 288, (byte)2, (byte)4, (byte)5, "Saveiro", (byte)4, (byte)1, (short)350, (short)2020, (byte)7 },
                    { 289, (byte)3, (byte)4, (byte)1, "Elan", (byte)1, (byte)4, (short)1100, (short)2017, (byte)5 },
                    { 290, (byte)1, (byte)4, (byte)3, "Magentis / Optima / K5", (byte)3, (byte)2, (short)1850, (short)2018, (byte)5 },
                    { 291, (byte)1, (byte)1, (byte)5, "Z8", (byte)3, (byte)1, (short)3100, (short)2017, (byte)5 },
                    { 292, (byte)4, (byte)3, (byte)4, "X5", (byte)3, (byte)3, (short)2200, (short)2016, (byte)5 },
                    { 293, (byte)3, (byte)3, (byte)5, "X5", (byte)4, (byte)2, (short)2500, (short)2015, (byte)7 },
                    { 294, (byte)3, (byte)1, (byte)1, "Series 75", (byte)4, (byte)4, (short)2650, (short)2019, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 295, (byte)4, (byte)2, (byte)2, "Series 65", (byte)1, (byte)1, (short)3200, (short)2018, (byte)5 },
                    { 296, (byte)2, (byte)3, (byte)3, "Fleetwood Brougham", (byte)3, (byte)4, (short)1350, (short)2019, (byte)7 },
                    { 297, (byte)3, (byte)4, (byte)4, "Series 60 (Sixty Special)", (byte)3, (byte)4, (short)450, (short)2020, (byte)5 },
                    { 298, (byte)3, (byte)3, (byte)1, "Series 61", (byte)3, (byte)3, (short)1500, (short)2016, (byte)7 },
                    { 299, (byte)1, (byte)3, (byte)3, "Sedan de Ville", (byte)1, (byte)2, (short)2350, (short)2021, (byte)5 },
                    { 300, (byte)1, (byte)1, (byte)3, "XT5", (byte)3, (byte)2, (short)2950, (short)2017, (byte)2 },
                    { 301, (byte)4, (byte)4, (byte)2, "Sorento", (byte)1, (byte)4, (short)2950, (short)2015, (byte)2 },
                    { 302, (byte)2, (byte)1, (byte)2, "7-Series", (byte)2, (byte)1, (short)450, (short)2017, (byte)5 },
                    { 303, (byte)2, (byte)3, (byte)5, "7-Series", (byte)1, (byte)1, (short)3200, (short)2019, (byte)2 },
                    { 304, (byte)4, (byte)4, (byte)3, "Series 60 (Sixty Special)", (byte)2, (byte)3, (short)650, (short)2022, (byte)2 },
                    { 305, (byte)1, (byte)1, (byte)4, "Pride", (byte)4, (byte)4, (short)1450, (short)2021, (byte)5 },
                    { 306, (byte)3, (byte)4, (byte)1, "Forte / K3", (byte)4, (byte)3, (short)1050, (short)2015, (byte)5 },
                    { 307, (byte)2, (byte)4, (byte)3, "New Six", (byte)3, (byte)4, (short)1200, (short)2015, (byte)2 },
                    { 308, (byte)3, (byte)1, (byte)4, "Eldorado", (byte)1, (byte)4, (short)3200, (short)2015, (byte)7 },
                    { 309, (byte)4, (byte)1, (byte)1, "Picanto", (byte)1, (byte)1, (short)650, (short)2017, (byte)2 },
                    { 310, (byte)3, (byte)3, (byte)2, "Carnival / Sedona", (byte)4, (byte)2, (short)1150, (short)2018, (byte)2 },
                    { 311, (byte)3, (byte)2, (byte)3, "Apollo", (byte)1, (byte)4, (short)2600, (short)2016, (byte)7 },
                    { 312, (byte)3, (byte)2, (byte)1, "4-Series, M4", (byte)1, (byte)3, (short)2200, (short)2015, (byte)7 },
                    { 313, (byte)1, (byte)3, (byte)4, "Series 60 (Sixty Special)", (byte)4, (byte)3, (short)3250, (short)2017, (byte)2 },
                    { 314, (byte)1, (byte)2, (byte)4, "Forte / K3", (byte)3, (byte)1, (short)1100, (short)2018, (byte)2 },
                    { 315, (byte)3, (byte)3, (byte)2, "Picanto", (byte)3, (byte)1, (short)400, (short)2018, (byte)7 },
                    { 316, (byte)4, (byte)1, (byte)4, "Mohave / Borrego", (byte)2, (byte)3, (short)1650, (short)2016, (byte)5 },
                    { 317, (byte)4, (byte)4, (byte)1, "ELR", (byte)1, (byte)1, (short)500, (short)2022, (byte)5 },
                    { 318, (byte)2, (byte)3, (byte)2, "Rio", (byte)1, (byte)1, (short)1150, (short)2020, (byte)5 },
                    { 319, (byte)3, (byte)2, (byte)2, "X4", (byte)3, (byte)4, (short)2450, (short)2022, (byte)5 },
                    { 320, (byte)2, (byte)1, (byte)5, "5-Series, M5", (byte)4, (byte)1, (short)1900, (short)2017, (byte)7 },
                    { 321, (byte)2, (byte)4, (byte)2, "Series 60 (Sixty Special)", (byte)4, (byte)2, (short)1150, (short)2021, (byte)7 },
                    { 322, (byte)1, (byte)1, (byte)3, "Series 60 (Sixty Special)", (byte)2, (byte)3, (short)400, (short)2019, (byte)2 },
                    { 323, (byte)1, (byte)3, (byte)2, "SRX", (byte)2, (byte)1, (short)1500, (short)2019, (byte)7 },
                    { 324, (byte)3, (byte)3, (byte)3, "Parati", (byte)2, (byte)3, (short)200, (short)2022, (byte)2 },
                    { 325, (byte)4, (byte)4, (byte)5, "Apollo", (byte)4, (byte)2, (short)2550, (short)2016, (byte)7 },
                    { 326, (byte)1, (byte)3, (byte)5, "BLS", (byte)1, (byte)4, (short)1000, (short)2016, (byte)5 },
                    { 327, (byte)4, (byte)1, (byte)1, "Retona", (byte)2, (byte)1, (short)3200, (short)2018, (byte)7 },
                    { 328, (byte)4, (byte)1, (byte)1, "Brougham", (byte)1, (byte)3, (short)800, (short)2020, (byte)2 },
                    { 329, (byte)3, (byte)2, (byte)5, "Cerato / Spectra", (byte)3, (byte)3, (short)2300, (short)2018, (byte)5 },
                    { 330, (byte)3, (byte)2, (byte)1, "Santana", (byte)1, (byte)1, (short)1600, (short)2017, (byte)7 },
                    { 331, (byte)2, (byte)2, (byte)4, "Cee'd", (byte)1, (byte)1, (short)1000, (short)2015, (byte)5 },
                    { 332, (byte)4, (byte)2, (byte)2, "Pride", (byte)2, (byte)3, (short)3450, (short)2016, (byte)7 },
                    { 333, (byte)1, (byte)1, (byte)1, "3200 CS", (byte)4, (byte)3, (short)850, (short)2021, (byte)5 },
                    { 334, (byte)4, (byte)1, (byte)1, "Concord", (byte)2, (byte)3, (short)2300, (short)2015, (byte)5 },
                    { 335, (byte)4, (byte)2, (byte)4, "Series 60", (byte)2, (byte)3, (short)3500, (short)2021, (byte)7 },
                    { 336, (byte)3, (byte)4, (byte)1, "Series 62", (byte)2, (byte)2, (short)600, (short)2021, (byte)2 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 337, (byte)2, (byte)3, (byte)5, "X1", (byte)1, (byte)3, (short)650, (short)2019, (byte)7 },
                    { 338, (byte)1, (byte)2, (byte)5, "Rio", (byte)4, (byte)4, (short)2750, (short)2018, (byte)7 },
                    { 339, (byte)1, (byte)1, (byte)5, "Rio", (byte)2, (byte)2, (short)500, (short)2019, (byte)2 },
                    { 340, (byte)1, (byte)4, (byte)1, "Series 61", (byte)1, (byte)1, (short)450, (short)2019, (byte)5 },
                    { 341, (byte)4, (byte)3, (byte)1, "6200", (byte)3, (byte)4, (short)2100, (short)2016, (byte)7 },
                    { 342, (byte)4, (byte)2, (byte)2, "XT4", (byte)3, (byte)1, (short)3050, (short)2016, (byte)2 },
                    { 343, (byte)3, (byte)4, (byte)1, "Cadenza / K7", (byte)3, (byte)2, (short)3450, (short)2021, (byte)7 },
                    { 344, (byte)4, (byte)4, (byte)3, "4-Series, M4", (byte)2, (byte)4, (short)650, (short)2016, (byte)2 },
                    { 345, (byte)1, (byte)1, (byte)1, "Sedan de Ville", (byte)3, (byte)1, (short)3450, (short)2021, (byte)5 },
                    { 346, (byte)1, (byte)3, (byte)4, "Gol", (byte)2, (byte)2, (short)2200, (short)2019, (byte)5 },
                    { 347, (byte)3, (byte)1, (byte)5, "XT5", (byte)3, (byte)3, (short)1600, (short)2017, (byte)5 },
                    { 348, (byte)1, (byte)4, (byte)1, "Pride", (byte)2, (byte)4, (short)2300, (short)2018, (byte)2 },
                    { 349, (byte)2, (byte)2, (byte)3, "XT5", (byte)4, (byte)3, (short)2050, (short)2017, (byte)5 },
                    { 350, (byte)3, (byte)4, (byte)1, "Magentis / Optima / K5", (byte)1, (byte)2, (short)1750, (short)2022, (byte)5 },
                    { 351, (byte)2, (byte)1, (byte)4, "Coupe de Ville", (byte)1, (byte)4, (short)1700, (short)2022, (byte)2 },
                    { 352, (byte)2, (byte)3, (byte)2, "Seville", (byte)2, (byte)4, (short)1600, (short)2016, (byte)7 },
                    { 353, (byte)4, (byte)2, (byte)4, "Picanto", (byte)3, (byte)2, (short)450, (short)2017, (byte)2 },
                    { 354, (byte)2, (byte)3, (byte)4, "X6", (byte)3, (byte)1, (short)3250, (short)2017, (byte)5 },
                    { 355, (byte)3, (byte)3, (byte)1, "SpaceFox / Suran / SportVan / Fox Plus", (byte)3, (byte)3, (short)900, (short)2019, (byte)5 },
                    { 356, (byte)2, (byte)3, (byte)4, "7-Series", (byte)1, (byte)2, (short)1200, (short)2021, (byte)7 },
                    { 357, (byte)4, (byte)3, (byte)2, "M1", (byte)3, (byte)4, (short)1850, (short)2015, (byte)5 },
                    { 358, (byte)1, (byte)3, (byte)4, "5-Series, M5", (byte)4, (byte)2, (short)2950, (short)2018, (byte)2 },
                    { 359, (byte)2, (byte)4, (byte)3, "5-Series, M5", (byte)1, (byte)1, (short)900, (short)2021, (byte)2 },
                    { 360, (byte)1, (byte)1, (byte)5, "Bongo", (byte)2, (byte)2, (short)1650, (short)2021, (byte)2 },
                    { 361, (byte)1, (byte)2, (byte)4, "SRX", (byte)4, (byte)4, (short)2650, (short)2018, (byte)2 },
                    { 362, (byte)2, (byte)2, (byte)4, "3-Series, M3", (byte)3, (byte)3, (short)3250, (short)2017, (byte)5 },
                    { 363, (byte)3, (byte)2, (byte)4, "Forte", (byte)4, (byte)2, (short)1800, (short)2017, (byte)5 },
                    { 364, (byte)4, (byte)1, (byte)1, "Fleetwood", (byte)4, (byte)4, (short)2000, (short)2018, (byte)5 },
                    { 365, (byte)2, (byte)4, (byte)4, "3-Series, M3", (byte)1, (byte)3, (short)3450, (short)2015, (byte)2 },
                    { 366, (byte)3, (byte)3, (byte)4, "Series 61", (byte)1, (byte)3, (short)950, (short)2015, (byte)2 },
                    { 367, (byte)2, (byte)1, (byte)5, "Series 75", (byte)3, (byte)3, (short)3050, (short)2019, (byte)7 },
                    { 368, (byte)3, (byte)3, (byte)3, "5-Series", (byte)4, (byte)2, (short)2000, (short)2017, (byte)5 },
                    { 369, (byte)3, (byte)4, (byte)3, "Sorento", (byte)4, (byte)3, (short)850, (short)2019, (byte)7 },
                    { 370, (byte)2, (byte)3, (byte)2, "Seville", (byte)4, (byte)4, (short)3300, (short)2018, (byte)2 },
                    { 371, (byte)2, (byte)1, (byte)4, "Voyage", (byte)2, (byte)3, (short)1900, (short)2021, (byte)7 },
                    { 372, (byte)2, (byte)1, (byte)4, "Pride", (byte)4, (byte)4, (short)1550, (short)2018, (byte)2 },
                    { 373, (byte)3, (byte)2, (byte)5, "Bongo Frontier", (byte)1, (byte)4, (short)1650, (short)2018, (byte)7 },
                    { 374, (byte)2, (byte)4, (byte)5, "Coupe de Ville", (byte)2, (byte)2, (short)1900, (short)2017, (byte)2 },
                    { 375, (byte)3, (byte)4, (byte)1, "Shuma", (byte)1, (byte)1, (short)1000, (short)2017, (byte)2 },
                    { 376, (byte)4, (byte)2, (byte)2, "CT6", (byte)1, (byte)2, (short)1750, (short)2022, (byte)7 },
                    { 377, (byte)3, (byte)1, (byte)3, "5-Series, M5", (byte)3, (byte)1, (short)3100, (short)2020, (byte)5 },
                    { 378, (byte)3, (byte)1, (byte)2, "Sephia", (byte)2, (byte)3, (short)200, (short)2019, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 379, (byte)1, (byte)1, (byte)4, "Parati", (byte)1, (byte)3, (short)1600, (short)2020, (byte)7 },
                    { 380, (byte)4, (byte)1, (byte)4, "Picanto", (byte)1, (byte)3, (short)2000, (short)2022, (byte)2 },
                    { 381, (byte)2, (byte)1, (byte)1, "8-Series", (byte)2, (byte)4, (short)2050, (short)2022, (byte)2 },
                    { 382, (byte)3, (byte)4, (byte)1, "Series 60 (Sixty Special)", (byte)1, (byte)1, (short)3450, (short)2018, (byte)5 },
                    { 383, (byte)2, (byte)3, (byte)5, "Carens", (byte)4, (byte)2, (short)1950, (short)2017, (byte)2 },
                    { 384, (byte)3, (byte)4, (byte)2, "Z4", (byte)4, (byte)4, (short)1400, (short)2015, (byte)7 },
                    { 385, (byte)4, (byte)3, (byte)1, "Parati", (byte)3, (byte)1, (short)3500, (short)2022, (byte)7 },
                    { 386, (byte)4, (byte)4, (byte)2, "Fleetwood 75", (byte)1, (byte)1, (short)1200, (short)2015, (byte)5 },
                    { 387, (byte)3, (byte)2, (byte)5, "6-Series, M6", (byte)3, (byte)3, (short)700, (short)2018, (byte)5 },
                    { 388, (byte)3, (byte)2, (byte)3, "Magentis / Optima / K5", (byte)2, (byte)1, (short)2400, (short)2022, (byte)7 },
                    { 389, (byte)2, (byte)4, (byte)4, "Series 60", (byte)4, (byte)3, (short)1750, (short)2015, (byte)5 },
                    { 390, (byte)2, (byte)3, (byte)4, "Seville", (byte)4, (byte)2, (short)1350, (short)2017, (byte)7 },
                    { 391, (byte)2, (byte)3, (byte)2, "Sedan de Ville", (byte)1, (byte)2, (short)900, (short)2018, (byte)7 },
                    { 392, (byte)3, (byte)1, (byte)2, "Fox", (byte)3, (byte)1, (short)200, (short)2022, (byte)7 },
                    { 393, (byte)3, (byte)4, (byte)1, "Bongo Frontier", (byte)3, (byte)3, (short)1950, (short)2022, (byte)7 },
                    { 394, (byte)1, (byte)1, (byte)1, "Retona", (byte)2, (byte)1, (short)2550, (short)2021, (byte)2 },
                    { 395, (byte)1, (byte)1, (byte)2, "Coupe de Ville", (byte)3, (byte)4, (short)1150, (short)2020, (byte)5 },
                    { 396, (byte)4, (byte)4, (byte)2, "X3", (byte)1, (byte)3, (short)1300, (short)2021, (byte)7 },
                    { 397, (byte)3, (byte)3, (byte)2, "Sorento", (byte)3, (byte)2, (short)2900, (short)2021, (byte)2 },
                    { 398, (byte)3, (byte)4, (byte)5, "Sedan de Ville", (byte)1, (byte)1, (short)1950, (short)2016, (byte)5 },
                    { 399, (byte)4, (byte)4, (byte)1, "Quoris / K9 / K900", (byte)1, (byte)3, (short)1350, (short)2019, (byte)7 },
                    { 400, (byte)4, (byte)3, (byte)4, "Fleetwood", (byte)3, (byte)3, (short)600, (short)2018, (byte)2 },
                    { 401, (byte)1, (byte)1, (byte)3, "Series 75", (byte)1, (byte)3, (short)1800, (short)2016, (byte)2 },
                    { 402, (byte)2, (byte)4, (byte)4, "Forte / K3", (byte)4, (byte)2, (short)400, (short)2019, (byte)5 },
                    { 403, (byte)3, (byte)4, (byte)1, "XT4", (byte)2, (byte)4, (short)1400, (short)2016, (byte)2 },
                    { 404, (byte)4, (byte)1, (byte)2, "DTS", (byte)2, (byte)4, (short)550, (short)2021, (byte)7 },
                    { 405, (byte)3, (byte)1, (byte)5, "Eldorado", (byte)4, (byte)3, (short)1500, (short)2020, (byte)5 },
                    { 406, (byte)4, (byte)4, (byte)3, "Series 60 (Sixty Special)", (byte)1, (byte)2, (short)2200, (short)2017, (byte)2 },
                    { 407, (byte)4, (byte)2, (byte)5, "Cadenza / K7", (byte)1, (byte)2, (short)700, (short)2020, (byte)2 },
                    { 408, (byte)4, (byte)2, (byte)3, "Picanto", (byte)3, (byte)1, (short)1350, (short)2022, (byte)7 },
                    { 409, (byte)2, (byte)2, (byte)4, "CT6", (byte)1, (byte)1, (short)3400, (short)2015, (byte)5 },
                    { 410, (byte)1, (byte)3, (byte)3, "Carnival / Sedona", (byte)3, (byte)1, (short)1200, (short)2017, (byte)5 },
                    { 411, (byte)1, (byte)1, (byte)1, "DTS", (byte)3, (byte)2, (short)1450, (short)2018, (byte)5 },
                    { 412, (byte)4, (byte)1, (byte)2, "Escalade", (byte)3, (byte)1, (short)200, (short)2021, (byte)5 },
                    { 413, (byte)1, (byte)4, (byte)5, "Sephia", (byte)3, (byte)4, (short)2050, (short)2018, (byte)5 },
                    { 414, (byte)4, (byte)1, (byte)5, "Apollo", (byte)2, (byte)4, (short)2000, (short)2016, (byte)5 },
                    { 415, (byte)2, (byte)3, (byte)2, "BLS", (byte)1, (byte)2, (short)2400, (short)2020, (byte)7 },
                    { 416, (byte)3, (byte)1, (byte)2, "Sephia", (byte)1, (byte)3, (short)2550, (short)2016, (byte)2 },
                    { 417, (byte)3, (byte)3, (byte)3, "Gol", (byte)4, (byte)1, (short)1300, (short)2021, (byte)2 },
                    { 418, (byte)4, (byte)1, (byte)2, "X1", (byte)4, (byte)3, (short)150, (short)2022, (byte)5 },
                    { 419, (byte)1, (byte)2, (byte)4, "Opirus / Amanti", (byte)1, (byte)3, (short)3400, (short)2022, (byte)5 },
                    { 420, (byte)3, (byte)4, (byte)4, "Seville", (byte)3, (byte)3, (short)700, (short)2016, (byte)7 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 421, (byte)2, (byte)2, (byte)1, "Eldorado", (byte)2, (byte)3, (short)2750, (short)2016, (byte)2 },
                    { 422, (byte)2, (byte)4, (byte)3, "Eldorado", (byte)2, (byte)4, (short)3150, (short)2018, (byte)2 },
                    { 423, (byte)3, (byte)4, (byte)5, "Sedan de Ville", (byte)4, (byte)1, (short)2950, (short)2020, (byte)5 },
                    { 424, (byte)3, (byte)1, (byte)3, "New Six CS", (byte)2, (byte)1, (short)2250, (short)2020, (byte)5 },
                    { 425, (byte)2, (byte)1, (byte)4, "SP2", (byte)2, (byte)2, (short)2900, (short)2017, (byte)7 },
                    { 426, (byte)4, (byte)4, (byte)1, "Series 60 (Sixty Special)", (byte)1, (byte)1, (short)3250, (short)2022, (byte)2 },
                    { 427, (byte)2, (byte)1, (byte)5, "5-Series GT", (byte)4, (byte)1, (short)2050, (short)2018, (byte)7 },
                    { 428, (byte)4, (byte)2, (byte)4, "XTS", (byte)3, (byte)2, (short)1300, (short)2017, (byte)7 },
                    { 429, (byte)1, (byte)1, (byte)3, "Series 60 (Sixty Special)", (byte)2, (byte)3, (short)3150, (short)2019, (byte)5 },
                    { 430, (byte)1, (byte)4, (byte)4, "Cee'd", (byte)1, (byte)3, (short)2100, (short)2017, (byte)2 },
                    { 431, (byte)3, (byte)4, (byte)1, "Joice", (byte)1, (byte)4, (short)2700, (short)2017, (byte)2 },
                    { 432, (byte)2, (byte)4, (byte)5, "Sedan de Ville", (byte)1, (byte)3, (short)1100, (short)2021, (byte)5 },
                    { 433, (byte)2, (byte)3, (byte)3, "Escalade", (byte)3, (byte)3, (short)550, (short)2015, (byte)5 },
                    { 434, (byte)1, (byte)4, (byte)5, "Series 62", (byte)4, (byte)4, (short)2450, (short)2017, (byte)5 },
                    { 435, (byte)3, (byte)3, (byte)3, "X6", (byte)3, (byte)1, (short)2550, (short)2019, (byte)5 },
                    { 436, (byte)1, (byte)2, (byte)3, "Sedan de Ville", (byte)1, (byte)2, (short)3250, (short)2017, (byte)7 },
                    { 437, (byte)1, (byte)4, (byte)3, "Eldorado", (byte)2, (byte)1, (short)2100, (short)2021, (byte)7 },
                    { 438, (byte)3, (byte)3, (byte)4, "X3", (byte)1, (byte)4, (short)2500, (short)2015, (byte)5 },
                    { 439, (byte)4, (byte)2, (byte)4, "Pride", (byte)4, (byte)3, (short)2000, (short)2019, (byte)5 },
                    { 440, (byte)3, (byte)3, (byte)5, "Enterprise", (byte)2, (byte)1, (short)2300, (short)2020, (byte)5 },
                    { 441, (byte)2, (byte)4, (byte)1, "New Six CS", (byte)1, (byte)3, (short)1400, (short)2015, (byte)7 },
                    { 442, (byte)2, (byte)2, (byte)5, "Eldorado", (byte)3, (byte)1, (short)700, (short)2017, (byte)7 },
                    { 443, (byte)3, (byte)1, (byte)1, "Forte / K3", (byte)2, (byte)4, (short)850, (short)2017, (byte)5 },
                    { 444, (byte)2, (byte)4, (byte)1, "Eldorado", (byte)1, (byte)4, (short)2800, (short)2021, (byte)7 },
                    { 445, (byte)1, (byte)3, (byte)1, "Series 60 (Sixty Special)", (byte)3, (byte)2, (short)3300, (short)2017, (byte)7 },
                    { 446, (byte)1, (byte)1, (byte)4, "Concord", (byte)2, (byte)4, (short)2450, (short)2015, (byte)2 },
                    { 447, (byte)1, (byte)3, (byte)3, "3-Series, M3", (byte)2, (byte)4, (short)2800, (short)2017, (byte)2 },
                    { 448, (byte)4, (byte)1, (byte)1, "CTS", (byte)4, (byte)2, (short)300, (short)2021, (byte)5 },
                    { 449, (byte)4, (byte)4, (byte)1, "SpaceFox / Suran / SportVan / Fox Plus", (byte)3, (byte)1, (short)1650, (short)2020, (byte)7 },
                    { 450, (byte)1, (byte)1, (byte)3, "Series 62", (byte)3, (byte)4, (short)2950, (short)2022, (byte)2 },
                    { 451, (byte)2, (byte)4, (byte)2, "New Six CS", (byte)2, (byte)3, (short)850, (short)2022, (byte)5 },
                    { 452, (byte)4, (byte)3, (byte)5, "Cadenza / K7", (byte)2, (byte)2, (short)2900, (short)2021, (byte)5 },
                    { 453, (byte)4, (byte)2, (byte)5, "Cadenza / K7", (byte)2, (byte)3, (short)1800, (short)2018, (byte)5 },
                    { 454, (byte)3, (byte)3, (byte)5, "Eldorado", (byte)1, (byte)4, (short)2200, (short)2017, (byte)2 },
                    { 455, (byte)3, (byte)3, (byte)1, "Opirus / Amanti", (byte)1, (byte)1, (short)450, (short)2019, (byte)2 },
                    { 456, (byte)1, (byte)1, (byte)2, "Sephia", (byte)3, (byte)4, (short)1100, (short)2019, (byte)7 },
                    { 457, (byte)1, (byte)2, (byte)2, "M1", (byte)2, (byte)4, (short)1600, (short)2020, (byte)7 },
                    { 458, (byte)1, (byte)3, (byte)3, "Bongo", (byte)1, (byte)3, (short)600, (short)2022, (byte)7 },
                    { 459, (byte)3, (byte)1, (byte)4, "Z4", (byte)3, (byte)3, (short)350, (short)2021, (byte)2 },
                    { 460, (byte)1, (byte)4, (byte)4, "Seville", (byte)4, (byte)2, (short)2250, (short)2020, (byte)7 },
                    { 461, (byte)4, (byte)1, (byte)2, "Series 61", (byte)4, (byte)1, (short)1550, (short)2022, (byte)7 },
                    { 462, (byte)3, (byte)1, (byte)5, "X3", (byte)1, (byte)1, (short)1400, (short)2018, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarID", "BodyTypeID", "BrandID", "CarColorID", "CarModel", "FuelTypeID", "GearTypeID", "LuggageVolume", "ModelYear", "SeatNumber" },
                values: new object[,]
                {
                    { 463, (byte)3, (byte)2, (byte)4, "Series 62", (byte)2, (byte)3, (short)650, (short)2015, (byte)5 },
                    { 464, (byte)2, (byte)2, (byte)1, "SRX", (byte)4, (byte)1, (short)1300, (short)2021, (byte)5 },
                    { 465, (byte)1, (byte)2, (byte)2, "Quantum", (byte)4, (byte)3, (short)2000, (short)2015, (byte)2 },
                    { 466, (byte)1, (byte)1, (byte)3, "Shuma", (byte)4, (byte)2, (short)1200, (short)2019, (byte)5 },
                    { 467, (byte)3, (byte)3, (byte)2, "Series 75", (byte)3, (byte)2, (short)1750, (short)2021, (byte)2 },
                    { 468, (byte)1, (byte)2, (byte)3, "Carnival / Sedona", (byte)4, (byte)2, (short)600, (short)2019, (byte)5 },
                    { 469, (byte)3, (byte)2, (byte)3, "Cimarron", (byte)4, (byte)2, (short)2800, (short)2019, (byte)7 },
                    { 470, (byte)2, (byte)3, (byte)3, "4-Series, M4", (byte)1, (byte)4, (short)3200, (short)2016, (byte)2 },
                    { 471, (byte)3, (byte)3, (byte)3, "Seville", (byte)2, (byte)3, (short)1000, (short)2015, (byte)2 },
                    { 472, (byte)3, (byte)2, (byte)3, "Cee'd", (byte)3, (byte)2, (short)1250, (short)2016, (byte)7 },
                    { 473, (byte)2, (byte)1, (byte)5, "X6", (byte)2, (byte)1, (short)500, (short)2019, (byte)2 },
                    { 474, (byte)3, (byte)3, (byte)1, "Gol", (byte)3, (byte)1, (short)2900, (short)2020, (byte)2 },
                    { 475, (byte)3, (byte)2, (byte)2, "Quantum", (byte)3, (byte)2, (short)2050, (short)2020, (byte)2 },
                    { 476, (byte)4, (byte)1, (byte)3, "X4", (byte)1, (byte)3, (short)3250, (short)2017, (byte)5 },
                    { 477, (byte)2, (byte)1, (byte)3, "Gol", (byte)3, (byte)2, (short)2150, (short)2022, (byte)5 },
                    { 478, (byte)2, (byte)4, (byte)1, "X3", (byte)1, (byte)4, (short)1050, (short)2022, (byte)5 },
                    { 479, (byte)3, (byte)3, (byte)5, "ATS", (byte)2, (byte)1, (short)1000, (short)2017, (byte)2 },
                    { 480, (byte)1, (byte)3, (byte)4, "XT4", (byte)3, (byte)1, (short)2200, (short)2017, (byte)7 },
                    { 481, (byte)2, (byte)2, (byte)3, "Coupe de Ville", (byte)1, (byte)1, (short)700, (short)2016, (byte)7 },
                    { 482, (byte)4, (byte)2, (byte)1, "Bongo", (byte)3, (byte)4, (short)3200, (short)2016, (byte)7 },
                    { 483, (byte)3, (byte)4, (byte)4, "Series 75", (byte)3, (byte)1, (short)1950, (short)2019, (byte)2 },
                    { 484, (byte)1, (byte)3, (byte)5, "Rio", (byte)3, (byte)2, (short)2700, (short)2017, (byte)7 },
                    { 485, (byte)3, (byte)4, (byte)3, "Eldorado", (byte)1, (byte)1, (short)1850, (short)2019, (byte)7 },
                    { 486, (byte)1, (byte)3, (byte)2, "Sephia", (byte)4, (byte)1, (short)3200, (short)2021, (byte)5 },
                    { 487, (byte)1, (byte)3, (byte)5, "Gol", (byte)4, (byte)1, (short)3200, (short)2018, (byte)2 },
                    { 488, (byte)4, (byte)1, (byte)3, "Cee'd", (byte)2, (byte)3, (short)450, (short)2022, (byte)7 },
                    { 489, (byte)2, (byte)1, (byte)5, "X3", (byte)1, (byte)3, (short)3000, (short)2015, (byte)2 },
                    { 490, (byte)3, (byte)3, (byte)5, "Pride", (byte)2, (byte)4, (short)1100, (short)2021, (byte)5 },
                    { 491, (byte)3, (byte)3, (byte)4, "Eldorado", (byte)1, (byte)2, (short)1100, (short)2017, (byte)5 },
                    { 492, (byte)3, (byte)3, (byte)2, "Series 62", (byte)4, (byte)1, (short)450, (short)2018, (byte)2 },
                    { 493, (byte)2, (byte)4, (byte)1, "X1", (byte)3, (byte)3, (short)2550, (short)2021, (byte)2 },
                    { 494, (byte)4, (byte)2, (byte)3, "i3", (byte)1, (byte)1, (short)3250, (short)2019, (byte)2 },
                    { 495, (byte)2, (byte)1, (byte)5, "Fox", (byte)4, (byte)1, (short)750, (short)2015, (byte)2 },
                    { 496, (byte)4, (byte)2, (byte)1, "4-Series, M4", (byte)3, (byte)4, (short)1850, (short)2017, (byte)5 },
                    { 497, (byte)4, (byte)1, (byte)4, "Sephia", (byte)4, (byte)3, (short)2950, (short)2021, (byte)7 },
                    { 498, (byte)4, (byte)3, (byte)5, "Sedan de Ville", (byte)1, (byte)3, (short)2200, (short)2015, (byte)5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyTypeID",
                table: "Cars",
                column: "BodyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandID",
                table: "Cars",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarColorID",
                table: "Cars",
                column: "CarColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeID",
                table: "Cars",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearTypeID",
                table: "Cars",
                column: "GearTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "BodyTypes");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarColors");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "GearTypes");
        }
    }
}
