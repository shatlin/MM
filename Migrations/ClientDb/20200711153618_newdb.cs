using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MM.Migrations.ClientDb
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Affliation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affliation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrespondenceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrespondenceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 5, nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 3, nullable: false),
                    Symbol = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(nullable: true),
                    TablePrimaryKeyValue = table.Column<int>(nullable: false),
                    Int1 = table.Column<int>(nullable: true),
                    Int2 = table.Column<int>(nullable: true),
                    Int3 = table.Column<int>(nullable: true),
                    Int4 = table.Column<int>(nullable: true),
                    Int5 = table.Column<int>(nullable: true),
                    Int6 = table.Column<int>(nullable: true),
                    Int7 = table.Column<int>(nullable: true),
                    Int8 = table.Column<int>(nullable: true),
                    Int9 = table.Column<int>(nullable: true),
                    Int10 = table.Column<int>(nullable: true),
                    Int11 = table.Column<int>(nullable: true),
                    Int12 = table.Column<int>(nullable: true),
                    Int13 = table.Column<int>(nullable: true),
                    Int14 = table.Column<int>(nullable: true),
                    Int15 = table.Column<int>(nullable: true),
                    Int16 = table.Column<int>(nullable: true),
                    Int17 = table.Column<int>(nullable: true),
                    Int18 = table.Column<int>(nullable: true),
                    Int19 = table.Column<int>(nullable: true),
                    Int20 = table.Column<int>(nullable: true),
                    Lookup1 = table.Column<int>(nullable: true),
                    Lookup2 = table.Column<int>(nullable: true),
                    Lookup3 = table.Column<int>(nullable: true),
                    Lookup4 = table.Column<int>(nullable: true),
                    Lookup5 = table.Column<int>(nullable: true),
                    Lookup6 = table.Column<int>(nullable: true),
                    Lookup7 = table.Column<int>(nullable: true),
                    Lookup8 = table.Column<int>(nullable: true),
                    Lookup9 = table.Column<int>(nullable: true),
                    Lookup10 = table.Column<int>(nullable: true),
                    Lookup11 = table.Column<int>(nullable: true),
                    Lookup12 = table.Column<int>(nullable: true),
                    Lookup13 = table.Column<int>(nullable: true),
                    Lookup14 = table.Column<int>(nullable: true),
                    Lookup15 = table.Column<int>(nullable: true),
                    Lookup16 = table.Column<int>(nullable: true),
                    Lookup17 = table.Column<int>(nullable: true),
                    Lookup18 = table.Column<int>(nullable: true),
                    Lookup19 = table.Column<int>(nullable: true),
                    Lookup20 = table.Column<int>(nullable: true),
                    Text1 = table.Column<string>(nullable: true),
                    Text2 = table.Column<string>(nullable: true),
                    Text3 = table.Column<string>(nullable: true),
                    Text4 = table.Column<string>(nullable: true),
                    Text5 = table.Column<string>(nullable: true),
                    Text6 = table.Column<string>(nullable: true),
                    Text7 = table.Column<string>(nullable: true),
                    Text8 = table.Column<string>(nullable: true),
                    Text9 = table.Column<string>(nullable: true),
                    Text10 = table.Column<string>(nullable: true),
                    Text11 = table.Column<string>(nullable: true),
                    Text12 = table.Column<string>(nullable: true),
                    Text13 = table.Column<string>(nullable: true),
                    Text14 = table.Column<string>(nullable: true),
                    Text15 = table.Column<string>(nullable: true),
                    Text16 = table.Column<string>(nullable: true),
                    Text17 = table.Column<string>(nullable: true),
                    Text18 = table.Column<string>(nullable: true),
                    Text19 = table.Column<string>(nullable: true),
                    Text20 = table.Column<string>(nullable: true),
                    Datetime1 = table.Column<DateTime>(nullable: true),
                    Datetime2 = table.Column<DateTime>(nullable: true),
                    Datetime3 = table.Column<DateTime>(nullable: true),
                    Datetime4 = table.Column<DateTime>(nullable: true),
                    Datetime5 = table.Column<DateTime>(nullable: true),
                    Datetime6 = table.Column<DateTime>(nullable: true),
                    Datetime7 = table.Column<DateTime>(nullable: true),
                    Datetime8 = table.Column<DateTime>(nullable: true),
                    Datetime9 = table.Column<DateTime>(nullable: true),
                    Datetime10 = table.Column<DateTime>(nullable: true),
                    Datetime11 = table.Column<DateTime>(nullable: true),
                    Datetime12 = table.Column<DateTime>(nullable: true),
                    Datetime13 = table.Column<DateTime>(nullable: true),
                    Datetime14 = table.Column<DateTime>(nullable: true),
                    Datetime15 = table.Column<DateTime>(nullable: true),
                    Datetime16 = table.Column<DateTime>(nullable: true),
                    Datetime17 = table.Column<DateTime>(nullable: true),
                    Datetime18 = table.Column<DateTime>(nullable: true),
                    Datetime19 = table.Column<DateTime>(nullable: true),
                    Datetime20 = table.Column<DateTime>(nullable: true),
                    Decimal1 = table.Column<decimal>(nullable: true),
                    Decimal2 = table.Column<decimal>(nullable: true),
                    Decimal3 = table.Column<decimal>(nullable: true),
                    Decimal4 = table.Column<decimal>(nullable: true),
                    Decimal5 = table.Column<decimal>(nullable: true),
                    Decimal6 = table.Column<decimal>(nullable: true),
                    Decimal7 = table.Column<decimal>(nullable: true),
                    Decimal8 = table.Column<decimal>(nullable: true),
                    Decimal9 = table.Column<decimal>(nullable: true),
                    Decimal10 = table.Column<decimal>(nullable: true),
                    Decimal11 = table.Column<decimal>(nullable: true),
                    Decimal12 = table.Column<decimal>(nullable: true),
                    Decimal13 = table.Column<decimal>(nullable: true),
                    Decimal14 = table.Column<decimal>(nullable: true),
                    Decimal15 = table.Column<decimal>(nullable: true),
                    Decimal16 = table.Column<decimal>(nullable: true),
                    Decimal17 = table.Column<decimal>(nullable: true),
                    Decimal18 = table.Column<decimal>(nullable: true),
                    Decimal19 = table.Column<decimal>(nullable: true),
                    Decimal20 = table.Column<decimal>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomField", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldLookUp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(maxLength: 50, nullable: false),
                    FieldIndex = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldLookUp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomFieldName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(maxLength: 50, nullable: false),
                    FieldIndex = table.Column<int>(nullable: true),
                    DataType = table.Column<string>(maxLength: 50, nullable: true),
                    Label = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomFieldName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplateName",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplateName", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EmailType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    EventCostItemId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10, 3)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventCostItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCostItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventMinuteStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventMinuteStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventResponseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventResponseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NextInvoiceNumber = table.Column<int>(nullable: false),
                    SendInvForPendingPayments = table.Column<bool>(nullable: false),
                    CopyInvToOrgContact = table.Column<bool>(nullable: false),
                    SendRecToPayer = table.Column<bool>(nullable: false),
                    CopyRecToOrgContact = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketingGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketingProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberCodeGenerator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Prefix = table.Column<string>(maxLength: 50, nullable: true),
                    LastNumber = table.Column<int>(nullable: true),
                    Suffix = table.Column<string>(maxLength: 50, nullable: true),
                    CodeGenerationRule = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCodeGenerator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberLoginAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    LoginTime = table.Column<int>(nullable: false),
                    LogoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberLoginAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberTeam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTeam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Acronym = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    WebSite = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationStructure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    LevelOfMember = table.Column<int>(nullable: false),
                    MaximumNumber = table.Column<int>(nullable: false),
                    MaximumTimeInYears = table.Column<int>(nullable: true),
                    ShowMaximumTimeInYears = table.Column<bool>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationStructure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentGateway",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    ClientIdForMerchant = table.Column<string>(maxLength: 100, nullable: true),
                    ClientPasswordForMerchant = table.Column<string>(maxLength: 100, nullable: true),
                    ClientAPICodeForMerchant = table.Column<string>(maxLength: 100, nullable: true),
                    MerchantNumber = table.Column<string>(maxLength: 100, nullable: true),
                    MerchantName = table.Column<string>(maxLength: 100, nullable: true),
                    MerchantLocation = table.Column<string>(maxLength: 100, nullable: true),
                    CommisionPercentage = table.Column<decimal>(type: "decimal(6, 3)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentGateway", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayPalConnectionMode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalConnectionMode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayPalPreferredPaymentGateway",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayPalPreferredPaymentGateway", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanFrequency",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanFrequency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BenefitStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BenefitEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionResponseType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionResponseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelatedTo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedTo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxCode = table.Column<string>(maxLength: 50, nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxPolicy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPolicy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaxScope",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxScopeCode = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxScope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ThemeNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeFormat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeZone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginAudit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    LoginTime = table.Column<int>(nullable: false),
                    LogoutTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankingDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccountTypeId = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: false),
                    BranchName = table.Column<string>(maxLength: 100, nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RoutingCode = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankingDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankingDetail_AccountType",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationPreference",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommunicationTypeId = table.Column<int>(nullable: false),
                    PreferredTimeFrom = table.Column<TimeSpan>(nullable: true),
                    PreferredTimeTo = table.Column<TimeSpan>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationPreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunicationPreference_CommunicationType",
                        column: x => x.CommunicationTypeId,
                        principalTable: "CommunicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CurrencyId = table.Column<int>(nullable: true),
                    GeneralInstructions = table.Column<string>(maxLength: 2000, nullable: true),
                    EventsInstructions = table.Column<string>(maxLength: 2000, nullable: true),
                    ApplicationInstructions = table.Column<string>(maxLength: 2000, nullable: true),
                    ClientPayPalConnectionModeId = table.Column<int>(nullable: true),
                    PayPalAccountId = table.Column<string>(maxLength: 200, nullable: true),
                    PayPalPDTIdentityToken = table.Column<string>(maxLength: 200, nullable: true),
                    DefaultCountryId = table.Column<int>(nullable: true),
                    PayPalAPIUserName = table.Column<string>(maxLength: 50, nullable: true),
                    PayPalAPIPassword = table.Column<string>(maxLength: 50, nullable: true),
                    PayPalAPISignature = table.Column<string>(maxLength: 200, nullable: true),
                    PayPalPreferredPaymentGatewayId = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSetting_Currency",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplateContent",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    EmailTemplateNameId = table.Column<int>(nullable: false),
                    EmailContent = table.Column<string>(maxLength: 4000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplateContent", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmailTemplateContent_EmailTemplateName",
                        column: x => x.EmailTemplateNameId,
                        principalTable: "EmailTemplateName",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentCount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipmentId = table.Column<int>(nullable: false),
                    AvaialbleCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentCount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentCount_Equipment",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberCategoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberType_MemberCategory",
                        column: x => x.MemberCategoryId,
                        principalTable: "MemberCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrganizationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberBranch_Organization",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPDMemberCategorySetUp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    MemberCategoryId = table.Column<int>(nullable: true),
                    CPDCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPDMemberCategorySetUp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPDMemberCategorySetUp_MemberCategory",
                        column: x => x.MemberCategoryId,
                        principalTable: "MemberCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPDMemberCategorySetUp_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPDMemberLevelSetUp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    MemberLevelId = table.Column<int>(nullable: true),
                    CPDCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPDMemberLevelSetUp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPDMemberLevelSetUp_MemberLevel",
                        column: x => x.MemberLevelId,
                        principalTable: "MemberLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPDMemberLevelSetUp_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPDMemberTeamSetUp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    MemberTeamId = table.Column<int>(nullable: true),
                    CPDCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPDMemberTeamSetUp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPDMemberTeamSetUp_MemberTeam",
                        column: x => x.MemberTeamId,
                        principalTable: "MemberTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPDMemberTeamSetUp_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailCCRule",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmailTypeId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailCCRule", x => x.id);
                    table.ForeignKey(
                        name: "FK_EmailCCRule_EmailType",
                        column: x => x.EmailTypeId,
                        principalTable: "EmailType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailCCRule_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissionXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    Permissionid = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissionXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissionXRef_Permission",
                        column: x => x.Permissionid,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissionXRef_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrganization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    AgreedToTerms = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateSettingId = table.Column<int>(nullable: true),
                    TimeFormatId = table.Column<int>(nullable: true),
                    TimeZoneId = table.Column<int>(nullable: true),
                    CurrencyId = table.Column<int>(nullable: true),
                    CurrencyDecimalPlaces = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Currency",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_DateSetting",
                        column: x => x.DateSettingId,
                        principalTable: "DateSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_TimeFormat",
                        column: x => x.TimeFormatId,
                        principalTable: "TimeFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_TimeZone",
                        column: x => x.TimeZoneId,
                        principalTable: "TimeZone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TitleId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailActivated = table.Column<bool>(nullable: false),
                    PrimaryContact = table.Column<bool>(nullable: false),
                    BillingContact = table.Column<bool>(nullable: false),
                    DesignationId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: false),
                    ReferralTypeId = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(maxLength: 1000, nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    IsInternalUser = table.Column<bool>(nullable: false),
                    TermsAccepted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Designation",
                        column: x => x.DesignationId,
                        principalTable: "Designation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Gender",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_ReferralType",
                        column: x => x.ReferralTypeId,
                        principalTable: "ReferralType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Title",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StateId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSettingAllowedCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentSettingId = table.Column<int>(nullable: false),
                    PaymentCardId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSettingAllowedCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSettingAllowedCard_PaymentCard",
                        column: x => x.PaymentCardId,
                        principalTable: "PaymentCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentSettingAllowedCard_PaymentSetting",
                        column: x => x.PaymentSettingId,
                        principalTable: "PaymentSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    MemberCategoryId = table.Column<int>(nullable: false),
                    IsLimited = table.Column<bool>(nullable: true),
                    LimitToMemberCount = table.Column<int>(nullable: true),
                    ApplyTaxSettings = table.Column<bool>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    CanPublicApply = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMaster_MemberCategory",
                        column: x => x.MemberCategoryId,
                        principalTable: "MemberCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanMaster_PaymentSetting",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPDMemberTypeSetUp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    MemberTypeId = table.Column<int>(nullable: true),
                    CPDCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPDMemberTypeSetUp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPDMemberTypeSetUp_MemberType",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPDMemberTypeSetUp_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LandingPage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberTypeId = table.Column<int>(nullable: false),
                    PageId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandingPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LandingPage_MemberType",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LandingPage_Page",
                        column: x => x.PageId,
                        principalTable: "Page",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PromotionMasterId = table.Column<int>(nullable: false),
                    MemberTypeId = table.Column<int>(nullable: true),
                    MemberLevelId = table.Column<int>(nullable: true),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(9, 3)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionDetail_MemberLevel",
                        column: x => x.MemberLevelId,
                        principalTable: "MemberLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromotionDetail_MemberType",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromotionDetail_PromotionMaster",
                        column: x => x.PromotionMasterId,
                        principalTable: "PromotionMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TitleId = table.Column<int>(nullable: false),
                    MemberBranchId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    ReferralTypeId = table.Column<int>(nullable: true),
                    OrganizationStructureId = table.Column<int>(nullable: true),
                    MemberCode = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    EmailActivated = table.Column<bool>(nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    NextRenewalDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MembershipConfirmed = table.Column<bool>(nullable: false),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MemberStatusId = table.Column<int>(nullable: true),
                    MemberLevelId = table.Column<int>(nullable: true),
                    MemberTeamId = table.Column<int>(nullable: true),
                    MemberTypeId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(type: "blob", nullable: true),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true),
                    IsBillingContact = table.Column<bool>(nullable: false),
                    IsBranchContact = table.Column<bool>(nullable: false),
                    TermAccepted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Gender",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_MemberBranch",
                        column: x => x.MemberBranchId,
                        principalTable: "MemberBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_MemberLevel",
                        column: x => x.MemberLevelId,
                        principalTable: "MemberLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_MemberStatus",
                        column: x => x.MemberStatusId,
                        principalTable: "MemberStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_MemberTeam",
                        column: x => x.MemberTeamId,
                        principalTable: "MemberTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_MemberType",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Organization",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_OrganizationStructure",
                        column: x => x.OrganizationStructureId,
                        principalTable: "OrganizationStructure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_ReferralType",
                        column: x => x.ReferralTypeId,
                        principalTable: "ReferralType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Member_Title",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientPlanHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillingUserId = table.Column<int>(nullable: false),
                    PlanDetailId = table.Column<int>(nullable: false),
                    IsCurrentPlan = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPlanHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientPlanHistory_User",
                        column: x => x.BillingUserId,
                        principalTable: "ClientUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User",
                        column: x => x.UserId,
                        principalTable: "ClientUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    BuidlingName = table.Column<string>(maxLength: 100, nullable: true),
                    ComplexName = table.Column<string>(maxLength: 100, nullable: true),
                    StreetName = table.Column<string>(maxLength: 100, nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    PrimaryContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    SecondaryContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    PrimaryEmail = table.Column<string>(maxLength: 50, nullable: true),
                    SecondaryEmail = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 50, nullable: true),
                    GPSCoordinates = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_City",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Country",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_State",
                        column: x => x.StateId,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanCanChangeToXref",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FromPlanMasterId = table.Column<int>(nullable: false),
                    ToPlanMasterId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanCanChangeToXref", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberPlanCanChangeTo_PlanMaster",
                        column: x => x.FromPlanMasterId,
                        principalTable: "PlanMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberPlanCanChangeTo_PlanMaster2",
                        column: x => x.ToPlanMasterId,
                        principalTable: "PlanMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PlanMasterId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    PlanFrequencyId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanDetail_Currency",
                        column: x => x.CurrencyId,
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanDetail_PlanFrequency",
                        column: x => x.PlanFrequencyId,
                        principalTable: "PlanFrequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanDetail_PlanMaster",
                        column: x => x.PlanMasterId,
                        principalTable: "PlanMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CPD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    CPDEarned = table.Column<int>(nullable: false),
                    CPDAwardedById = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPD_User",
                        column: x => x.CPDAwardedById,
                        principalTable: "ClientUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPD_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CPD_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    PromotionDetailId = table.Column<int>(nullable: true),
                    DonatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    DonorNotes = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donation_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Donation_PromotionDetail",
                        column: x => x.PromotionDetailId,
                        principalTable: "PromotionDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InvoiceCode = table.Column<string>(maxLength: 50, nullable: false),
                    RelatedToId = table.Column<int>(nullable: true),
                    RelatedRecordId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    InvoiceStatusId = table.Column<int>(nullable: false),
                    PaymentGatewayId = table.Column<int>(nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    InvoiceItem = table.Column<string>(maxLength: 200, nullable: false),
                    InvoiceAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CommentsForPayer = table.Column<string>(maxLength: 1000, nullable: true),
                    InternalNotes = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_InvoiceStatus",
                        column: x => x.InvoiceStatusId,
                        principalTable: "InvoiceStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_PaymentGateway",
                        column: x => x.PaymentGatewayId,
                        principalTable: "PaymentGateway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarketingGroupXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    MarketingGroupId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingGroupXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingGroupXRef_MarketingGroup",
                        column: x => x.MarketingGroupId,
                        principalTable: "MarketingGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarketingGroupXRef_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarketingProfileXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    MarketingProfileId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingProfileXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketingProfileXRef_MarketingProfile",
                        column: x => x.MarketingProfileId,
                        principalTable: "MarketingProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarketingProfileXRef_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    BranchId = table.Column<int>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 100, nullable: true),
                    BuidlingName = table.Column<string>(maxLength: 100, nullable: true),
                    ComplexName = table.Column<string>(maxLength: 100, nullable: true),
                    StreetName = table.Column<string>(maxLength: 100, nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    PrimaryContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    SecondaryContactNo = table.Column<string>(maxLength: 50, nullable: true),
                    PrimaryEmail = table.Column<string>(maxLength: 50, nullable: true),
                    SecondaryEmail = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNumber = table.Column<string>(maxLength: 50, nullable: true),
                    GPSCoordinates = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberAddress_AddressType",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberAddress_MemberBranch",
                        column: x => x.BranchId,
                        principalTable: "MemberBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberAddress_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberAddress_Organization",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberAffliationXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: true),
                    AffliationId = table.Column<int>(nullable: true),
                    MemberSpecificAffliationName = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    AffliatedFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    AffliatedTill = table.Column<DateTime>(type: "datetime", nullable: false),
                    isActiveAffliatedNow = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAffliationXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberAffliationXRef_Affliation",
                        column: x => x.AffliationId,
                        principalTable: "Affliation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberAffliationXRef_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberBankingDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    AccountTypeId = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: true),
                    BranchName = table.Column<string>(maxLength: 100, nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 50, nullable: false),
                    RoutingCode = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBankingDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberBankingDetail_AccountType",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberBankingDetail_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberCommunicationPreference",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    CommunicationTypeId = table.Column<int>(nullable: false),
                    PreferredTimeFrom = table.Column<TimeSpan>(nullable: true),
                    PreferredTimeTo = table.Column<TimeSpan>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCommunicationPreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberCommunicationPreference_CommunicationType",
                        column: x => x.CommunicationTypeId,
                        principalTable: "CommunicationType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberCommunicationPreference_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberFile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    FileTypeId = table.Column<int>(nullable: false),
                    FileContent = table.Column<byte[]>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberFile_FileType",
                        column: x => x.FileTypeId,
                        principalTable: "FileType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberFile_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberQualificationXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    QualificationId = table.Column<int>(nullable: true),
                    MemberSpecificQualificationName = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    QualificationFrom = table.Column<DateTime>(type: "datetime", nullable: false),
                    QualificationTill = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberQualificationXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberQualificationXRef_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberQualificationXRef_Qualification",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromotionResponse",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PromotionMasterId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    PromotionResponseType = table.Column<int>(nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionResponse_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromotionResponse_PromotionMaster",
                        column: x => x.PromotionMasterId,
                        principalTable: "PromotionMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PromotionResponse_PromotionResponseType",
                        column: x => x.PromotionResponseType,
                        principalTable: "PromotionResponseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Refund",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InvoiceId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    PaymentGatewayId = table.Column<int>(nullable: false),
                    RelatedToId = table.Column<int>(nullable: true),
                    RelatedRecordId = table.Column<int>(nullable: true),
                    RefundDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RefundItem = table.Column<string>(maxLength: 200, nullable: false),
                    RefundAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    CommentsForPayer = table.Column<string>(maxLength: 1000, nullable: true),
                    InternalNotes = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refund", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refund_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Refund_PaymentGateway",
                        column: x => x.PaymentGatewayId,
                        principalTable: "PaymentGateway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Refund_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventUniqueName = table.Column<string>(maxLength: 20, nullable: false),
                    InternalOrExternal = table.Column<bool>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    OrganizerId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    TimeZoneId = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time(2)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(2)", nullable: false),
                    RegStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegStartTime = table.Column<TimeSpan>(type: "time(2)", nullable: false),
                    RegEndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RegEndTime = table.Column<TimeSpan>(type: "time(2)", nullable: false),
                    MaxRegistrationsAllowed = table.Column<int>(nullable: false),
                    IsCPDEvent = table.Column<bool>(nullable: false),
                    IsChargableEvent = table.Column<bool>(nullable: false),
                    ShowMaxRegistrationsAllowed = table.Column<bool>(nullable: false),
                    AllowGuestRegistrations = table.Column<bool>(nullable: true),
                    GuestLimitPerRegistrant = table.Column<int>(nullable: true),
                    AllowCancellations = table.Column<bool>(nullable: false),
                    CancellationbeforeDays = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    AllowRegistration = table.Column<bool>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Address",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_User",
                        column: x => x.OrganizerId,
                        principalTable: "ClientUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_TimeZone",
                        column: x => x.TimeZoneId,
                        principalTable: "TimeZone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberPlanHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    MemberPlanDetailId = table.Column<int>(nullable: false),
                    IsCurrentPlan = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Notes = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberPlanHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MembershipHistory_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberPlanHistory_PlanDetail",
                        column: x => x.MemberPlanDetailId,
                        principalTable: "PlanDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MembershipHistory_PlanMaster",
                        column: x => x.MemberPlanDetailId,
                        principalTable: "PlanMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MembershipHistory_Organization",
                        column: x => x.OrganizationId,
                        principalTable: "Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Billing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    InvoiceId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    RelatedToId = table.Column<int>(nullable: false),
                    RelatedRecordId = table.Column<int>(nullable: false),
                    PaymentGatewayId = table.Column<int>(nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaidDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaymentItem = table.Column<string>(maxLength: 200, nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18, 3)", nullable: true),
                    CommentsForPayer = table.Column<string>(maxLength: 1000, nullable: true),
                    InternalNotes = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Invoice",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentGateway",
                        column: x => x.PaymentGatewayId,
                        principalTable: "PaymentGateway",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Billing_RelatedTo",
                        column: x => x.RelatedToId,
                        principalTable: "RelatedTo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventAccess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    AdminOnly = table.Column<bool>(nullable: true),
                    Anyone = table.Column<bool>(nullable: true),
                    RestrictedList = table.Column<bool>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAccess_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventAttendance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    SignInTime = table.Column<TimeSpan>(nullable: false),
                    SingOutTime = table.Column<TimeSpan>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventAttendance_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventAttendance_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventCommunication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    Announcement1Sent = table.Column<bool>(nullable: true),
                    Announcement1SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Announcement1ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Announcement2Sent = table.Column<bool>(nullable: true),
                    Announcement2SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Announcement2ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Announcement3Sent = table.Column<bool>(nullable: true),
                    Announcement3SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Announcement3ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder1Sent = table.Column<bool>(nullable: true),
                    Reminder1SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder1ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder2Sent = table.Column<bool>(nullable: true),
                    Reminder2SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder2ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder3Sent = table.Column<bool>(nullable: true),
                    Reminder3SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder3ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCommunication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventCommunication_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    EquipmentId = table.Column<int>(nullable: false),
                    RequiredCount = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventEquipmentRequirement_Equipment",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventEquipmentRequirement_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventMinute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    Heading = table.Column<string>(maxLength: 50, nullable: true),
                    SubHeading = table.Column<string>(maxLength: 50, nullable: true),
                    Minute = table.Column<string>(maxLength: 100, nullable: false),
                    RaisedBy = table.Column<int>(nullable: false),
                    AssignedTo = table.Column<int>(nullable: false),
                    MinuteStatusId = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventMinute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventMinute_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventMinute_EventMinuteStatus",
                        column: x => x.MinuteStatusId,
                        principalTable: "EventMinuteStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventPreRequisiteEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    PreRequisiteEventId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPreRequisiteEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventPreRequisiteEvent_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventPreRequisiteEvent_PreRequisiteEventId_Event",
                        column: x => x.PreRequisiteEventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    EventResponseTypeId = table.Column<int>(nullable: false),
                    Cancelled = table.Column<bool>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    NumberOfGuests = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRegistration_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRegistration_EventResponseType",
                        column: x => x.EventResponseTypeId,
                        principalTable: "EventResponseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRegistration_Member",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventRestrictionList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    MemberLevelId = table.Column<int>(nullable: true),
                    MemberTeamId = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRestrictionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRestrictionList_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRestrictionList_MemberLevel",
                        column: x => x.MemberLevelId,
                        principalTable: "MemberLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRestrictionList_MemberTeam",
                        column: x => x.MemberTeamId,
                        principalTable: "MemberTeam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRole_Event",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillingCommunication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BillingId = table.Column<int>(nullable: false),
                    Reminder1Sent = table.Column<bool>(nullable: true),
                    Reminder1SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder1ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder2Sent = table.Column<bool>(nullable: true),
                    Reminder2SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder2ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder3Sent = table.Column<bool>(nullable: true),
                    Reminder3SentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reminder3ScheduledDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingCommunication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentCommunication_Payment",
                        column: x => x.Id,
                        principalTable: "Billing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillingCommunication_Client",
                        column: x => x.Id,
                        principalTable: "ClientOrganization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventRoleUserXRef",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    EventRoleId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventRoleUserXRef", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventRoleUserXRef_EventRole",
                        column: x => x.EventRoleId,
                        principalTable: "EventRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventRoleUserXRef_User",
                        column: x => x.UserId,
                        principalTable: "ClientUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClientType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 81, DateTimeKind.Local).AddTicks(8660), "Individual", null, new DateTime(2020, 7, 11, 17, 36, 17, 83, DateTimeKind.Local).AddTicks(6043), "Individual" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 83, DateTimeKind.Local).AddTicks(7234), "Organization", null, new DateTime(2020, 7, 11, 17, 36, 17, 83, DateTimeKind.Local).AddTicks(7256), "Organization" }
                });

            migrationBuilder.InsertData(
                table: "Designation",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 14, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1741), "Chief Operating Officer (COO)", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1743), "Chief Operating Officer (COO)" },
                    { 13, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1736), "Vice President of Marketing or Marketing Manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1738), "Vice President of Marketing or Marketing Manager" },
                    { 12, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1730), "Chief Financial Officer (CFO)", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1732), "Chief Financial Officer (CFO)" },
                    { 11, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1725), "Production Manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1727), "Production Manager" },
                    { 10, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1720), "Professional staff", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1721), "Professional staff" },
                    { 9, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1712), "Shipping and receiving person or manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1714), "Shipping and receiving person or manager" },
                    { 8, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1707), "Purchasing manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1709), "Purchasing manager" },
                    { 7, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1702), "Marketing manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1704), "Marketing manager" },
                    { 6, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1696), "Foreperson, supervisor, lead person", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1698), "Foreperson, supervisor, lead person" },
                    { 5, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1691), "Receptionist", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1693), "Receptionist" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1685), "Office manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1688), "Office manager" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1680), "Accountant, bookkeeper, controller", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1682), "Accountant, bookkeeper, controller" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1641), "Quality control, safety, environmental manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(1663), "Quality control, safety, environmental manager" },
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 131, DateTimeKind.Local).AddTicks(9807), "Operations manager", null, new DateTime(2020, 7, 11, 17, 36, 17, 132, DateTimeKind.Local).AddTicks(739), "Operations manager" },
                    { 15, null, null, "Chief Executive Officer (CEO) or President", null, null, "Chief Executive Officer (CEO) or President" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(8878), "Female", null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(8903), "Female" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(8927), "Other", null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(8930), "Other" },
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(6663), "Male", null, new DateTime(2020, 7, 11, 17, 36, 17, 219, DateTimeKind.Local).AddTicks(7754), "Male" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(5713), "Can create new contacts, modify all existing ones  ", null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(6639), "Membership manager" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7559), "Can create and manage all events", null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7577), "Event manager" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7591), "Can manage all donations", null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7594), "Donations manager" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7597), "Can send manual emails (e.g. newsletters)", null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7599), "Newsletter manager" },
                    { 5, null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7602), "Can modify your website pages. With this option selected, you can provide access to all pages on your site or to selected pages. When you grant access to a page, you automatically grant access to all of its child or sub pages.", null, new DateTime(2020, 7, 11, 17, 36, 17, 341, DateTimeKind.Local).AddTicks(7604), "Website editor" }
                });

            migrationBuilder.InsertData(
                table: "ReferralType",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 5, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9433), "Friends", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9435), "Friends" },
                    { 6, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9439), "Other", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9441), "Other" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9427), "TV", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9429), "TV" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9421), "Twitter", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9423), "Twitter" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9389), "Facebook", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(9407), "Facebook" },
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(7603), "Google", null, new DateTime(2020, 7, 11, 17, 36, 17, 375, DateTimeKind.Local).AddTicks(8509), "Google" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(702), "Select this option to remove admin access for existing administrators  ", null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(1606), "No administrative privileges" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2499), "Grants full access to all administrative functions. Take care when granting this level of access since full admins can delete other admins and even the entire site.", null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2521), "Account administrator" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2566), "Allows viewing of everything in the admin backend without being able to make any changes.  ", null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2569), "Account administrator (Read-only access)" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2575), "Provides administrative access to selected Wild Apricot modules. Use this option if you have dedicated personnel in charge of events, memberships, editing webpages, or managing donations. With this option selected, you can limit access to selected Functions", null, new DateTime(2020, 7, 11, 17, 36, 17, 387, DateTimeKind.Local).AddTicks(2577), "Limited administrator" }
                });

            migrationBuilder.InsertData(
                table: "TimeFormat",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(19), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(21), "Fri, December 03, 2020" },
                    { 8, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(15), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(17), "Friday, December 03, 2020" },
                    { 11, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(28), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(29), "03 December 2020" },
                    { 10, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(24), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(25), "December 03, 2020" },
                    { 7, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(11), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(12), "2020-12-03" },
                    { 12, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(32), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(33), "3 Dec 2020" },
                    { 5, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(1), "03 Dec 2020" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9995), null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9997), "03-12-2020" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9990), null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9992), "03.12.2020" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9956), null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9976), "03/12/2020" },
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(8376), null, new DateTime(2020, 7, 11, 17, 36, 17, 406, DateTimeKind.Local).AddTicks(9189), "12/03/2020" },
                    { 6, null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(6), null, new DateTime(2020, 7, 11, 17, 36, 17, 407, DateTimeKind.Local).AddTicks(8), "03-Dec-2020" }
                });

            migrationBuilder.InsertData(
                table: "TimeZone",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 70, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3109), "(GMT+10:00) Vladivostok", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3111), "Vladivostok Standard Time" },
                    { 69, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3105), "(GMT+10:00) Hobart", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3106), "Tasmania Standard Time" },
                    { 68, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3100), "(GMT+10:00) Brisbane", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3102), "E. Australia Standard Time" },
                    { 67, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3095), "(GMT+10:00) Canberra, Melbourne, Sydney", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3097), "A.U.S. Eastern Standard Time" },
                    { 66, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3091), "(GMT+09:30) AdelaIde", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3092), "Cen. Australia Standard Time" },
                    { 65, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3086), "(GMT+09:30) Darwin", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3088), "A.U.S. Central Standard Time" },
                    { 64, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3082), "(GMT+09:00) Yakutsk", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3083), "Yakutsk Standard Time" },
                    { 63, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3077), "(GMT+09:00) Osaka, Sapporo, Tokyo", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3079), "Tokyo Standard Time" },
                    { 62, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3072), "(GMT+09:00) Seoul", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3074), "Korea Standard Time" },
                    { 61, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3068), "(GMT+08:00) Irkutsk, Ulaanbaatar", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3069), "North Asia East Standard Time" },
                    { 58, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3053), "(GMT+08:00) Kuala Lumpur, Singapore", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3055), "Singapore Standard Time" },
                    { 59, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3058), "(GMT+08:00) Taipei", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3060), "Taipei Standard Time" },
                    { 57, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3049), "(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3050), "China Standard Time" },
                    { 56, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3044), "(GMT+07:00) Krasnoyarsk", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3046), "North Asia Standard Time" },
                    { 55, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3039), "(GMT+07:00) Bangkok, Hanoi, Jakarta", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3041), "S.E. Asia Standard Time" },
                    { 54, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3034), "(GMT+06:30) Yangon (Rangoon)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3036), "Myanmar Standard Time" },
                    { 53, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3030), "(GMT+06:00) Almaty, Novosibirsk", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3031), "N. Central Asia Standard Time" },
                    { 52, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3025), "(GMT+06:00) Sri Jayawardenepura", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3027), "Sri Lanka Standard Time" },
                    { 51, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3020), "(GMT+06:00) Astana, Dhaka", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3021), "Central Asia Standard Time" },
                    { 50, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3015), "(GMT+05:45) Kathmandu", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3016), "Nepal Standard Time" },
                    { 60, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3063), "(GMT+08:00) Perth", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3065), "W. Australia Standard Time" },
                    { 71, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3114), "(GMT+10:00) Guam, Port Moresby", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3116), "West Pacific Standard Time" },
                    { 74, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3128), "(GMT+12:00) Auckland, Wellington", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3130), "New Zealand Standard Time" },
                    { 73, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3123), "(GMT+12:00) Fiji, Kamchatka, Marshall Is.", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3125), "Fiji Islands Standard Time" },
                    { 49, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3010), "(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3012), "India Standard Time" },
                    { 94, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3228), "(GMT+12:00) Petropavlovsk-Kamchatsky", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3229), "Kamchatka Standard Time" },
                    { 93, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3223), "(GMT-04:00) Asuncion", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3225), "Paraguay Standard Time" },
                    { 92, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3218), "(GMT) Coordinated Universal Time", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3220), "UTC" },
                    { 91, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3213), "(GMT+04:00) Port Louis", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3215), "Mauritius Standard Time" },
                    { 90, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3209), "(GMT+05:00) Islamabad, Karachi", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3210), "Pakistan Standard Time" },
                    { 89, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3204), "(GMT) Casablanca", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3206), "Morocco Standard Time" },
                    { 88, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3200), "(GMT-03:00) Buenos Aires", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3201), "Argentina Standard Time" },
                    { 87, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3195), "(GMT-04:30) Caracas", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3196), "Venezuela Standard Time" },
                    { 86, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3190), "(GMT+04:00) Yerevan", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3192), "Armenian Standard Time" },
                    { 85, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3185), "(GMT-03:00) MontevIdeo", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3187), "MontevIdeo Standard Time" },
                    { 84, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3181), "(GMT-04:00) Manaus", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3182), "Central Brazilian Standard Time" },
                    { 83, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3176), "(GMT+03:00) Tbilisi", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3178), "Georgian Standard Time" },
                    { 82, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3165), "(GMT+02:00) Windhoek", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3167), "Namibia Standard Time" },
                    { 81, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3161), "(GMT-08:00) Tijuana, Baja California", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3162), "Pacific Standard Time (Mexico)" },
                    { 80, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3156), "(GMT-07:00) Chihuahua, La Paz, Mazatlan - New", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3157), "Mountain Standard Time (Mexico)" },
                    { 79, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3151), "(GMT-06:00) Guadalajara, Mexico City, Monterrey - New", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3153), "Central Standard Time (Mexico)" },
                    { 78, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3147), "(GMT+02:00) Amman", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3148), "Jordan Standard Time" },
                    { 77, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3142), "(GMT+02:00) Beirut", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3144), "MIddle East Standard Time" },
                    { 76, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3137), "(GMT-03:00) Buenos Aires", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3139), "Azerbaijan Standard Time " },
                    { 75, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3133), "(GMT+13:00) Nuku'alofa", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3134), "Tonga Standard Time" },
                    { 72, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3119), "(GMT+11:00) Magadan, Solomon Islands, New Caledonia", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3120), "Central Pacific Standard Time" },
                    { 48, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3005), "(GMT+05:00) Tashkent", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(3007), "West Asia Standard Time" },
                    { 26, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2894), "(GMT) Greenwich Mean Time: Dublin, Edinburgh, Lisbon, London", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2896), "GMT Standard Time" },
                    { 46, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2989), "(GMT+04:30) Kabul", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2991), "Transitional Islamic State of Afghanistan Standard Time" },
                    { 20, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2866), "(GMT-03:00) Brasilia", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2868), "E. South America Standard Time" },
                    { 19, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2861), "(GMT-03:30) Newfoundland", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2863), "Newfoundland and Labrador Standard Time" },
                    { 18, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2856), "(GMT-04:00) Santiago", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2858), "Pacific S.A. Standard Time" },
                    { 17, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2852), "(GMT-04:00) Georgetown, La Paz, San Juan", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2853), "S.A. Western Standard Time" },
                    { 16, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2847), "(GMT-04:00) Atlantic Time (Canada)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2849), "Atlantic Standard Time" },
                    { 15, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2842), "(GMT-05:00) Bogota, Lima, Quito", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2844), "S.A. Pacific Standard Time" },
                    { 14, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2837), "(GMT-05:00) Indiana (East)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2839), "U.S. Eastern Standard Time" },
                    { 13, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2832), "(GMT-05:00) Eastern Time (US and Canada)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2834), "Eastern Standard Time" },
                    { 12, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2809), "(GMT-06:00) Central America", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2811), "Central America Standard Time" },
                    { 21, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2871), "(GMT-03:00) Georgetown", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2872), "S.A. Eastern Standard Time" },
                    { 11, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2802), "(GMT-06:00) Guadalajara, Mexico City, Monterrey", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2804), "Mexico Standard Time" },
                    { 9, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2793), "(GMT-06:00) Central Time (US and Canada)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2795), "Central Standard Time" },
                    { 8, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2788), "(GMT-07:00) Arizona", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2790), "U.S. Mountain Standard Time" },
                    { 7, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2783), "(GMT-07:00) Chihuahua, La Paz, Mazatlan", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2785), "Mexico Standard Time 2" },
                    { 6, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2778), "(GMT-07:00) Mountain Time (US and Canada)", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2780), "Mountain Standard Time" },
                    { 5, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2773), "(GMT-08:00) Pacific Time (US and Canada); Tijuana", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2775), "Pacific Standard Time" },
                    { 4, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2768), "(GMT-09:00) Alaska", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2770), "Alaskan Standard Time" },
                    { 3, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2763), "(GMT-10:00) Hawaii", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2764), "Hawaiian Standard Time" },
                    { 2, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2731), "(GMT-11:00) MIdway Island, Samoa", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2748), "Samoa Standard Time" },
                    { 1, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(1022), "(GMT-12:00) International Date Line West", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(1835), "Dateline Standard Time" },
                    { 10, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2798), "(GMT-06:00) Saskatchewan", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2799), "Canada Central Standard Time" },
                    { 47, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2994), "(GMT+05:00) Ekaterinburg", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2996), "Ekaterinburg Standard Time" },
                    { 22, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2875), "(GMT-03:00) Greenland", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2877), "Greenland Standard Time" },
                    { 24, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2885), "(GMT-01:00) Azores", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2887), "Azores Standard Time" },
                    { 45, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2985), "(GMT+04:00) Baku, Tbilisi, Yerevan", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2986), "Caucasus Standard Time" },
                    { 44, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2980), "(GMT+04:00) Abu Dhabi, Muscat", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2982), "Arabian Standard Time" },
                    { 43, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2975), "(GMT+03:30) Tehran", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2976), "Iran Standard Time" },
                    { 42, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2970), "(GMT+03:00) Baghdad", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2972), "Arabic Standard Time" },
                    { 41, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2966), "(GMT+03:00) Nairobi", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2967), "E. Africa Standard Time" },
                    { 40, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2961), "(GMT+03:00) Kuwait, Riyadh", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2963), "Arab Standard Time" },
                    { 39, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2956), "(GMT+03:00) Moscow, St. Petersburg, Volgograd", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2958), "Russian Standard Time" },
                    { 38, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2951), "(GMT+02:00) Harare, Pretoria", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2953), "South Africa Standard Time" },
                    { 37, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2947), "(GMT+02:00) Jerusalem", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2948), "Israel Standard Time" },
                    { 23, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2880), "(GMT-02:00) MId-Atlantic", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2882), "MId-Atlantic Standard Time" },
                    { 36, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2942), "(GMT+02:00) Athens, Bucharest, Istanbul", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2944), "GTB Standard Time" },
                    { 34, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2932), "(GMT+02:00) Cairo", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2934), "Egypt Standard Time" },
                    { 33, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2928), "(GMT+02:00) Minsk", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2929), "E. Europe Standard Time" },
                    { 32, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2923), "(GMT+01:00) West Central Africa", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2925), "W. Central Africa Standard Time" },
                    { 31, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2918), "(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2920), "W. Europe Standard Time" },
                    { 30, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2913), "(GMT+01:00) Brussels, Copenhagen, MadrId, Paris", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2915), "Romance Standard Time" },
                    { 29, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2909), "(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2910), "Central European Standard Time" },
                    { 28, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2904), "(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2906), "Central Europe Standard Time" },
                    { 27, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2899), "(GMT) Monrovia, Reykjavik", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2901), "Greenwich Standard Time" },
                    { 25, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2890), "(GMT-01:00) Cape Verde Islands", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2891), "Cape Verde Standard Time" },
                    { 35, null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2937), "(GMT+02:00) Helsinki, Kiev, Riga, Sofia, Tallinn, Vilnius", null, new DateTime(2020, 7, 11, 17, 36, 17, 416, DateTimeKind.Local).AddTicks(2939), "FLE Standard Time" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "ModifiedBy", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 30, null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8507), "Ms", null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8508), "Ms" },
                    { 10, null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(6948), "Mr", null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(7705), "Mr" },
                    { 20, null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8474), "Mrs", null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8492), "Mrs" },
                    { 40, null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8512), "Dr", null, new DateTime(2020, 7, 11, 17, 36, 17, 418, DateTimeKind.Local).AddTicks(8514), "Dr" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityId",
                table: "Address",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryId",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_StateId",
                table: "Address",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_BankingDetail_AccountTypeId",
                table: "BankingDetail",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_InvoiceId",
                table: "Billing",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_MemberId",
                table: "Billing",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_PaymentGatewayId",
                table: "Billing",
                column: "PaymentGatewayId");

            migrationBuilder.CreateIndex(
                name: "IX_Billing_RelatedToId",
                table: "Billing",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrganization_CurrencyId",
                table: "ClientOrganization",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrganization_DateSettingId",
                table: "ClientOrganization",
                column: "DateSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrganization_TimeFormatId",
                table: "ClientOrganization",
                column: "TimeFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrganization_TimeZoneId",
                table: "ClientOrganization",
                column: "TimeZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientPlanHistory_BillingUserId",
                table: "ClientPlanHistory",
                column: "BillingUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUser_DesignationId",
                table: "ClientUser",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUser_GenderId",
                table: "ClientUser",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUser_ReferralTypeId",
                table: "ClientUser",
                column: "ReferralTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUser_RoleId",
                table: "ClientUser",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientUser_TitleId",
                table: "ClientUser",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationPreference_CommunicationTypeId",
                table: "CommunicationPreference",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPD_CPDAwardedById",
                table: "CPD",
                column: "CPDAwardedById");

            migrationBuilder.CreateIndex(
                name: "IX_CPD_MemberId",
                table: "CPD",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_CPD_RelatedToId",
                table: "CPD",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberCategorySetUp_MemberCategoryId",
                table: "CPDMemberCategorySetUp",
                column: "MemberCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberCategorySetUp_RelatedToId",
                table: "CPDMemberCategorySetUp",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberLevelSetUp_MemberLevelId",
                table: "CPDMemberLevelSetUp",
                column: "MemberLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberLevelSetUp_RelatedToId",
                table: "CPDMemberLevelSetUp",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberTeamSetUp_MemberTeamId",
                table: "CPDMemberTeamSetUp",
                column: "MemberTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberTeamSetUp_RelatedToId",
                table: "CPDMemberTeamSetUp",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberTypeSetUp_MemberTypeId",
                table: "CPDMemberTypeSetUp",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPDMemberTypeSetUp_RelatedToId",
                table: "CPDMemberTypeSetUp",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_MemberId",
                table: "Donation",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_PromotionDetailId",
                table: "Donation",
                column: "PromotionDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailCCRule_EmailTypeId",
                table: "EmailCCRule",
                column: "EmailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailCCRule_RoleId",
                table: "EmailCCRule",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplateContent_EmailTemplateNameId",
                table: "EmailTemplateContent",
                column: "EmailTemplateNameId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentCount_EquipmentId",
                table: "EquipmentCount",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AddressId",
                table: "Event",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerId",
                table: "Event",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_TimeZoneId",
                table: "Event",
                column: "TimeZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAccess_EventId",
                table: "EventAccess",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendance_EventId",
                table: "EventAttendance",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendance_MemberId",
                table: "EventAttendance",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_EventCommunication_EventId",
                table: "EventCommunication",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventEquipment_EquipmentId",
                table: "EventEquipment",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EventEquipment_EventId",
                table: "EventEquipment",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventMinute_EventId",
                table: "EventMinute",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventMinute_MinuteStatusId",
                table: "EventMinute",
                column: "MinuteStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPreRequisiteEvent_EventId",
                table: "EventPreRequisiteEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventPreRequisiteEvent_PreRequisiteEventId",
                table: "EventPreRequisiteEvent",
                column: "PreRequisiteEventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_EventId",
                table: "EventRegistration",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_EventResponseTypeId",
                table: "EventRegistration",
                column: "EventResponseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRegistration_MemberId",
                table: "EventRegistration",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRestrictionList_EventId",
                table: "EventRestrictionList",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRestrictionList_MemberLevelId",
                table: "EventRestrictionList",
                column: "MemberLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRestrictionList_MemberTeamId",
                table: "EventRestrictionList",
                column: "MemberTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRole_EventId",
                table: "EventRole",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRoleUserXRef_EventRoleId",
                table: "EventRoleUserXRef",
                column: "EventRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EventRoleUserXRef_UserId",
                table: "EventRoleUserXRef",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_InvoiceStatusId",
                table: "Invoice",
                column: "InvoiceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_MemberId",
                table: "Invoice",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_PaymentGatewayId",
                table: "Invoice",
                column: "PaymentGatewayId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_RelatedToId",
                table: "Invoice",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_LandingPage_MemberTypeId",
                table: "LandingPage",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LandingPage_PageId",
                table: "LandingPage",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingGroupXRef_MarketingGroupId",
                table: "MarketingGroupXRef",
                column: "MarketingGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingGroupXRef_MemberId",
                table: "MarketingGroupXRef",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingProfileXRef_MarketingProfileId",
                table: "MarketingProfileXRef",
                column: "MarketingProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketingProfileXRef_MemberId",
                table: "MarketingProfileXRef",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_GenderId",
                table: "Member",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberBranchId",
                table: "Member",
                column: "MemberBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberLevelId",
                table: "Member",
                column: "MemberLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberStatusId",
                table: "Member",
                column: "MemberStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberTeamId",
                table: "Member",
                column: "MemberTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_MemberTypeId",
                table: "Member",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_OrganizationId",
                table: "Member",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_OrganizationStructureId",
                table: "Member",
                column: "OrganizationStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_ReferralTypeId",
                table: "Member",
                column: "ReferralTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_TitleId",
                table: "Member",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAddress_AddressTypeId",
                table: "MemberAddress",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAddress_BranchId",
                table: "MemberAddress",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAddress_MemberId",
                table: "MemberAddress",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAddress_OrganizationId",
                table: "MemberAddress",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAffliationXRef_AffliationId",
                table: "MemberAffliationXRef",
                column: "AffliationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAffliationXRef_MemberId",
                table: "MemberAffliationXRef",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberBankingDetail_AccountTypeId",
                table: "MemberBankingDetail",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberBankingDetail_MemberId",
                table: "MemberBankingDetail",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberBranch_OrganizationId",
                table: "MemberBranch",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberCommunicationPreference_CommunicationTypeId",
                table: "MemberCommunicationPreference",
                column: "CommunicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberCommunicationPreference_MemberId",
                table: "MemberCommunicationPreference",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberFile_FileTypeId",
                table: "MemberFile",
                column: "FileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberFile_MemberId",
                table: "MemberFile",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPlanHistory_MemberId",
                table: "MemberPlanHistory",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPlanHistory_MemberPlanDetailId",
                table: "MemberPlanHistory",
                column: "MemberPlanDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPlanHistory_OrganizationId",
                table: "MemberPlanHistory",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberQualificationXRef_MemberId",
                table: "MemberQualificationXRef",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberQualificationXRef_QualificationId",
                table: "MemberQualificationXRef",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberType_MemberCategoryId",
                table: "MemberType",
                column: "MemberCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSetting_CurrencyId",
                table: "PaymentSetting",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSettingAllowedCard_PaymentCardId",
                table: "PaymentSettingAllowedCard",
                column: "PaymentCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSettingAllowedCard_PaymentSettingId",
                table: "PaymentSettingAllowedCard",
                column: "PaymentSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanCanChangeToXref_FromPlanMasterId",
                table: "PlanCanChangeToXref",
                column: "FromPlanMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanCanChangeToXref_ToPlanMasterId",
                table: "PlanCanChangeToXref",
                column: "ToPlanMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetail_CurrencyId",
                table: "PlanDetail",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetail_PlanFrequencyId",
                table: "PlanDetail",
                column: "PlanFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetail_PlanMasterId",
                table: "PlanDetail",
                column: "PlanMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMaster_MemberCategoryId",
                table: "PlanMaster",
                column: "MemberCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMaster_PaymentMethodId",
                table: "PlanMaster",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_MemberLevelId",
                table: "PromotionDetail",
                column: "MemberLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_MemberTypeId",
                table: "PromotionDetail",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetail_PromotionMasterId",
                table: "PromotionDetail",
                column: "PromotionMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionResponse_MemberId",
                table: "PromotionResponse",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionResponse_PromotionMasterId",
                table: "PromotionResponse",
                column: "PromotionMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionResponse_PromotionResponseType",
                table: "PromotionResponse",
                column: "PromotionResponseType");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_MemberId",
                table: "Refund",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_PaymentGatewayId",
                table: "Refund",
                column: "PaymentGatewayId");

            migrationBuilder.CreateIndex(
                name: "IX_Refund_RelatedToId",
                table: "Refund",
                column: "RelatedToId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionXRef_Permissionid",
                table: "RolePermissionXRef",
                column: "Permissionid");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissionXRef_RoleId",
                table: "RolePermissionXRef",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleXRef_RoleId",
                table: "UserRoleXRef",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleXRef_UserId",
                table: "UserRoleXRef",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankingDetail");

            migrationBuilder.DropTable(
                name: "BillingCommunication");

            migrationBuilder.DropTable(
                name: "ClientPlanHistory");

            migrationBuilder.DropTable(
                name: "ClientType");

            migrationBuilder.DropTable(
                name: "CommunicationPreference");

            migrationBuilder.DropTable(
                name: "CorrespondenceType");

            migrationBuilder.DropTable(
                name: "CPD");

            migrationBuilder.DropTable(
                name: "CPDMemberCategorySetUp");

            migrationBuilder.DropTable(
                name: "CPDMemberLevelSetUp");

            migrationBuilder.DropTable(
                name: "CPDMemberTeamSetUp");

            migrationBuilder.DropTable(
                name: "CPDMemberTypeSetUp");

            migrationBuilder.DropTable(
                name: "CustomField");

            migrationBuilder.DropTable(
                name: "CustomFieldLookUp");

            migrationBuilder.DropTable(
                name: "CustomFieldName");

            migrationBuilder.DropTable(
                name: "Donation");

            migrationBuilder.DropTable(
                name: "EmailCCRule");

            migrationBuilder.DropTable(
                name: "EmailTemplateContent");

            migrationBuilder.DropTable(
                name: "EquipmentCount");

            migrationBuilder.DropTable(
                name: "EventAccess");

            migrationBuilder.DropTable(
                name: "EventAttendance");

            migrationBuilder.DropTable(
                name: "EventCommunication");

            migrationBuilder.DropTable(
                name: "EventCost");

            migrationBuilder.DropTable(
                name: "EventCostItem");

            migrationBuilder.DropTable(
                name: "EventEquipment");

            migrationBuilder.DropTable(
                name: "EventMinute");

            migrationBuilder.DropTable(
                name: "EventPreRequisiteEvent");

            migrationBuilder.DropTable(
                name: "EventRegistration");

            migrationBuilder.DropTable(
                name: "EventRestrictionList");

            migrationBuilder.DropTable(
                name: "EventRoleUserXRef");

            migrationBuilder.DropTable(
                name: "InvoiceSetting");

            migrationBuilder.DropTable(
                name: "LandingPage");

            migrationBuilder.DropTable(
                name: "MarketingGroupXRef");

            migrationBuilder.DropTable(
                name: "MarketingProfileXRef");

            migrationBuilder.DropTable(
                name: "MemberAddress");

            migrationBuilder.DropTable(
                name: "MemberAffliationXRef");

            migrationBuilder.DropTable(
                name: "MemberBankingDetail");

            migrationBuilder.DropTable(
                name: "MemberCodeGenerator");

            migrationBuilder.DropTable(
                name: "MemberCommunicationPreference");

            migrationBuilder.DropTable(
                name: "MemberFile");

            migrationBuilder.DropTable(
                name: "MemberLoginAudit");

            migrationBuilder.DropTable(
                name: "MemberPlanHistory");

            migrationBuilder.DropTable(
                name: "MemberQualificationXRef");

            migrationBuilder.DropTable(
                name: "PaymentSettingAllowedCard");

            migrationBuilder.DropTable(
                name: "PayPalConnectionMode");

            migrationBuilder.DropTable(
                name: "PayPalPreferredPaymentGateway");

            migrationBuilder.DropTable(
                name: "PlanCanChangeToXref");

            migrationBuilder.DropTable(
                name: "PromotionResponse");

            migrationBuilder.DropTable(
                name: "Refund");

            migrationBuilder.DropTable(
                name: "RolePermissionXRef");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropTable(
                name: "TaxPolicy");

            migrationBuilder.DropTable(
                name: "TaxScope");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "UserLoginAudit");

            migrationBuilder.DropTable(
                name: "UserRoleXRef");

            migrationBuilder.DropTable(
                name: "Billing");

            migrationBuilder.DropTable(
                name: "ClientOrganization");

            migrationBuilder.DropTable(
                name: "PromotionDetail");

            migrationBuilder.DropTable(
                name: "EmailType");

            migrationBuilder.DropTable(
                name: "EmailTemplateName");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EventMinuteStatus");

            migrationBuilder.DropTable(
                name: "EventResponseType");

            migrationBuilder.DropTable(
                name: "EventRole");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "MarketingGroup");

            migrationBuilder.DropTable(
                name: "MarketingProfile");

            migrationBuilder.DropTable(
                name: "Affliation");

            migrationBuilder.DropTable(
                name: "AccountType");

            migrationBuilder.DropTable(
                name: "CommunicationType");

            migrationBuilder.DropTable(
                name: "FileType");

            migrationBuilder.DropTable(
                name: "PlanDetail");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "PaymentCard");

            migrationBuilder.DropTable(
                name: "PromotionResponseType");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "DateSetting");

            migrationBuilder.DropTable(
                name: "TimeFormat");

            migrationBuilder.DropTable(
                name: "PromotionMaster");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "PlanFrequency");

            migrationBuilder.DropTable(
                name: "PlanMaster");

            migrationBuilder.DropTable(
                name: "InvoiceStatus");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "PaymentGateway");

            migrationBuilder.DropTable(
                name: "RelatedTo");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ClientUser");

            migrationBuilder.DropTable(
                name: "TimeZone");

            migrationBuilder.DropTable(
                name: "PaymentSetting");

            migrationBuilder.DropTable(
                name: "MemberBranch");

            migrationBuilder.DropTable(
                name: "MemberLevel");

            migrationBuilder.DropTable(
                name: "MemberStatus");

            migrationBuilder.DropTable(
                name: "MemberTeam");

            migrationBuilder.DropTable(
                name: "MemberType");

            migrationBuilder.DropTable(
                name: "OrganizationStructure");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Designation");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "ReferralType");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropTable(
                name: "MemberCategory");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
