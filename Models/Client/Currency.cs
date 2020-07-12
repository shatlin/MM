﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Currency
    {
        public Currency()
        {
            Client = new HashSet<ClientOrganization>();
            PaymentSetting = new HashSet<PaymentSetting>();
            PlanDetail = new HashSet<PlanDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ClientOrganization> Client { get; set; }
        public virtual ICollection<PaymentSetting> PaymentSetting { get; set; }
        public virtual ICollection<PlanDetail> PlanDetail { get; set; }
    }
    public partial class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(e => e.Code)
                        .IsRequired()
                        .HasMaxLength(3);

            builder.Property(e => e.Symbol)
               .IsRequired(false)
               .HasMaxLength(5);

            builder.Property(e => e.Name)
                             .IsRequired()
                             .HasMaxLength(50);
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Description).HasMaxLength(100);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

 
        }

    }
    public static partial class Seeder
    {
        public static void SeedCurrency(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Symbol = " ", Code = "AFN",  Name = "Afghani", Description = "Currency for  AFGHANISTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 2, Symbol = " ", Code = "ALL", Name = "Lek", Description = "ALBANIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 3, Symbol = " ", Code = "DZD", Name = "Algerian Dinar", Description = "ALGERIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 4, Symbol = " ", Code = "USD", Name = "US Dollar", Description = "AMERICAN SAMOA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 5, Symbol = " ", Code = "EUR", Name = "Euro", Description = "ANDORRA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 6, Symbol = " ", Code = "AOA", Name = "Kwanza", Description = "ANGOLA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 7, Symbol = " ", Code = "XCD", Name = "East Caribbean Dollar", Description = "ANGUILLA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 8, Symbol = " ", Code = "XCD", Name = "East Caribbean Dollar", Description = "ANTIGUA AND BARBUDA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 9, Symbol = "", Code = "ARS", Name = "Argentine Peso", Description = "ARGENTINA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 10, Symbol=" ",Code = "AMD", Name = "Armenian Dram", Description = "ARMENIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 11, Symbol=" ",Code = "AWG", Name = "Aruban Florin", Description = "ARUBA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 12, Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "AUSTRALIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 13, Symbol=" ",Code = "EUR", Name = "Euro", Description = "AUSTRIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 14, Symbol=" ",Code = "AZN", Name = "Azerbaijanian Manat", Description = "AZERBAIJAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 15, Symbol=" ",Code = "BSD", Name = "Bahamian Dollar", Description = "BAHAMAS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 16, Symbol=" ",Code = "BHD", Name = "Bahraini Dinar", Description = "BAHRAIN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 17, Symbol=" ",Code = "BDT", Name = "Taka", Description = "BANGLADESH", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 18, Symbol=" ",Code = "BBD", Name = "Barbados Dollar", Description = "BARBADOS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 19, Symbol=" ",Code = "BYN", Name = "Belarussian Ruble", Description = "BELARUS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 20, Symbol=" ",Code = "EUR", Name = "Euro", Description = "BELGIUM", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 21, Symbol=" ",Code = "BZD", Name = "Belize Dollar", Description = "BELIZE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 22, Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "BENIN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 23, Symbol=" ",Code = "BMD", Name = "Bermudian Dollar", Description = "BERMUDA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 24, Symbol=" ",Code = "BTN", Name = "Ngultrum", Description = "BHUTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 25, Symbol=" ",Code = "INR", Name = "Indian Rupee", Description = "BHUTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 26, Symbol=" ",Code = "BOB", Name = "Boliviano", Description = "BOLIVIA (PLURINATIONAL STATE OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 27, Symbol=" ",Code = "BOV", Name = "Mvdol", Description = "BOLIVIA (PLURINATIONAL STATE OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 28, Symbol=" ",Code = "USD", Name = "US Dollar", Description = "BONAIRE, SINT EUSTATIUS AND SABA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 29, Symbol=" ",Code = "BAM", Name = "Convertible Mark", Description = "BOSNIA AND HERZEGOVINA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 30, Symbol=" ",Code = "BWP", Name = "Pula", Description = "BOTSWANA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 31, Symbol=" ",Code = "NOK", Name = "Norwegian Krone", Description = "BOUVET ISLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 32, Symbol=" ",Code = "BRL", Name = "Brazilian Real", Description = "BRAZIL", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 33, Symbol=" ",Code = "USD", Name = "US Dollar", Description = "BRITISH INDIAN OCEAN TERRITORY (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 34, Symbol=" ",Code = "BND", Name = "Brunei Dollar", Description = "BRUNEI DARUSSALAM", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 35, Symbol=" ",Code = "BGN", Name = "Bulgarian Lev", Description = "BULGARIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 36, Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "BURKINA FASO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 37, Symbol=" ",Code = "BIF", Name = "Burundi Franc", Description = "BURUNDI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 38, Symbol=" ",Code = "CVE", Name = "Cabo Verde Escudo", Description = "CABO VERDE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 39, Symbol=" ",Code = "KHR", Name = "Riel", Description = "CAMBODIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 40, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "CAMEROON", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 41, Symbol=" ",Code = "CAD", Name = "Canadian Dollar", Description = "CANADA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 42, Symbol=" ",Code = "KYD", Name = "Cayman Islands Dollar", Description = "CAYMAN ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 43, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "CENTRAL AFRICAN REPUBLIC (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 44, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "CHAD", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 45, Symbol=" ",Code = "CLF", Name = "Unidad de Fomento", Description = "CHILE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 46, Symbol=" ",Code = "CLP", Name = "Chilean Peso", Description = "CHILE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 47, Symbol=" ",Code = "CNY", Name = "Yuan Renminbi", Description = "CHINA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 48, Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "CHRISTMAS ISLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 49, Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "COCOS (KEELING) ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 50, Symbol=" ",Code = "COP", Name = "Colombian Peso", Description = "COLOMBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 51, Symbol=" ",Code = "COU", Name = "Unidad de Valor Real", Description = "COLOMBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 52, Symbol=" ",Code = "KMF", Name = "Comoro Franc", Description = "COMOROS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 53, Symbol=" ",Code = "CDF", Name = "Congolese Franc", Description = "CONGO (THE DEMOCRATIC REPUBLIC OF THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 54, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "CONGO (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 55, Symbol=" ",Code = "NZD", Name = "New Zealand Dollar", Description = "COOK ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 56, Symbol=" ",Code = "CRC", Name = "Costa Rican Colon", Description = "COSTA RICA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 57, Symbol=" ",Code = "HRK", Name = "Kuna", Description = "CROATIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 58, Symbol=" ",Code = "CUC", Name = "Peso Convertible", Description = "CUBA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 59, Symbol=" ",Code = "CUP", Name = "Cuban Peso", Description = "CUBA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 60, Symbol=" ",Code = "ANG", Name = "Netherlands Antillean Guilder", Description = "CURAÇAO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 61, Symbol=" ",Code = "EUR", Name = "Euro", Description = "CYPRUS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 62, Symbol=" ",Code = "CZK", Name = "Czech Koruna", Description = "CZECH REPUBLIC (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 63, Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "CÔTE D'IVOIRE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 64, Symbol=" ",Code = "DKK", Name = "Danish Krone", Description = "DENMARK", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 65, Symbol=" ",Code = "DJF", Name = "Djibouti Franc", Description = "DJIBOUTI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 66, Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "DOMINICA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 67, Symbol=" ",Code = "DOP", Name = "Dominican Peso", Description = "DOMINICAN REPUBLIC (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 68, Symbol=" ",Code = "USD", Name = "US Dollar", Description = "ECUADOR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 69, Symbol=" ",Code = "EGP", Name = "Egyptian Pound", Description = "EGYPT", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 70, Symbol=" ",Code = "SVC", Name = "El Salvador Colon", Description = "EL SALVADOR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 71, Symbol=" ",Code = "USD", Name = "US Dollar", Description = "EL SALVADOR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 72, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "EQUATORIAL GUINEA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 73, Symbol=" ",Code = "ERN", Name = "Nakfa", Description = "ERITREA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 74, Symbol=" ",Code = "EUR", Name = "Euro", Description = "ESTONIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 75, Symbol=" ",Code = "ETB", Name = "Ethiopian Birr", Description = "ETHIOPIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 76, Symbol=" ",Code = "EUR", Name = "Euro", Description = "EUROPEAN UNION", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 77, Symbol=" ",Code = "FKP", Name = "Falkland Islands Pound", Description = "FALKLAND ISLANDS (THE) [MALVINAS]", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 78, Symbol=" ",Code = "DKK", Name = "Danish Krone", Description = "FAROE ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 79, Symbol=" ",Code = "FJD", Name = "Fiji Dollar", Description = "FIJI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 80, Symbol=" ",Code = "EUR", Name = "Euro", Description = "FINLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 81, Symbol=" ",Code = "EUR", Name = "Euro", Description = "FRANCE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 82, Symbol=" ",Code = "EUR", Name = "Euro", Description = "FRENCH GUIANA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 83, Symbol=" ",Code = "XPF", Name = "CFP Franc", Description = "FRENCH POLYNESIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 84, Symbol=" ",Code = "EUR", Name = "Euro", Description = "FRENCH SOUTHERN TERRITORIES (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 85, Symbol=" ",Code = "XAF", Name = "CFA Franc BEAC", Description = "GABON", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 86, Symbol=" ",Code = "GMD", Name = "Dalasi", Description = "GAMBIA (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 87, Symbol=" ",Code = "GEL", Name = "Lari", Description = "GEORGIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 88, Symbol=" ",Code = "EUR", Name = "Euro", Description = "GERMANY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 89, Symbol=" ",Code = "GHS", Name = "Ghana Cedi", Description = "GHANA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 90, Symbol=" ",Code = "GIP", Name = "Gibraltar Pound", Description = "GIBRALTAR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 91, Symbol=" ",Code = "EUR", Name = "Euro", Description = "GREECE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 92, Symbol=" ",Code = "DKK", Name = "Danish Krone", Description = "GREENLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 93, Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "GRENADA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 94, Symbol=" ",Code = "EUR", Name = "Euro", Description = "GUADELOUPE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 95, Symbol=" ",Code = "USD", Name = "US Dollar", Description = "GUAM", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 96, Symbol=" ",Code = "GTQ", Name = "Quetzal", Description = "GUATEMALA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 97, Symbol=" ",Code = "GBP", Name = "Pound Sterling", Description = "GUERNSEY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 98, Symbol=" ",Code = "GNF", Name = "Guinea Franc", Description = "GUINEA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 99, Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "GUINEA-BISSAU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 100,Symbol=" ",Code = "GYD", Name = "Guyana Dollar", Description = "GUYANA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 101,Symbol=" ",Code = "HTG", Name = "Gourde", Description = "HAITI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 102,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "HAITI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 103,Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "HEARD ISLAND AND McDONALD ISLANDS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 104,Symbol=" ",Code = "EUR", Name = "Euro", Description = "HOLY SEE (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 105,Symbol=" ",Code = "HNL", Name = "Lempira", Description = "HONDURAS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 106,Symbol=" ",Code = "HKD", Name = "Hong Kong Dollar", Description = "HONG KONG", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 107,Symbol=" ",Code = "HUF", Name = "Forint", Description = "HUNGARY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 108,Symbol=" ",Code = "ISK", Name = "Iceland Krona", Description = "ICELAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 109,Symbol=" ",Code = "INR", Name = "Indian Rupee", Description = "INDIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 110,Symbol=" ",Code = "IDR", Name = "Rupiah", Description = "INDONESIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 111,Symbol=" ",Code = "XDR", Name = "SDR (Special Drawing Right)", Description = "INTERNATIONAL MONETARY FUND (IMF) ", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 112,Symbol=" ",Code = "IRR", Name = "Iranian Rial", Description = "IRAN (ISLAMIC REPUBLIC OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 113,Symbol=" ",Code = "IQD", Name = "Iraqi Dinar", Description = "IRAQ", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 114,Symbol=" ",Code = "EUR", Name = "Euro", Description = "IRELAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 115,Symbol=" ",Code = "GBP", Name = "Pound Sterling", Description = "ISLE OF MAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 116,Symbol=" ",Code = "ILS", Name = "New Israeli Sheqel", Description = "ISRAEL", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 117,Symbol=" ",Code = "EUR", Name = "Euro", Description = "ITALY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 118,Symbol=" ",Code = "JMD", Name = "Jamaican Dollar", Description = "JAMAICA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 119,Symbol=" ",Code = "JPY", Name = "Yen", Description = "JAPAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 120,Symbol=" ",Code = "GBP", Name = "Pound Sterling", Description = "JERSEY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 121,Symbol=" ",Code = "JOD", Name = "Jordanian Dinar", Description = "JORDAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 122,Symbol=" ",Code = "KZT", Name = "Tenge", Description = "KAZAKHSTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 123,Symbol=" ",Code = "KES", Name = "Kenyan Shilling", Description = "KENYA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 124,Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "KIRIBATI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 125,Symbol=" ",Code = "KPW", Name = "North Korean Won", Description = "KOREA (THE DEMOCRATIC PEOPLE’S REPUBLIC OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 126,Symbol=" ",Code = "KRW", Name = "Won", Description = "KOREA (THE REPUBLIC OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 127,Symbol=" ",Code = "KWD", Name = "Kuwaiti Dinar", Description = "KUWAIT", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 128,Symbol=" ",Code = "KGS", Name = "Som", Description = "KYRGYZSTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 129,Symbol=" ",Code = "LAK", Name = "Kip", Description = "LAO PEOPLE’S DEMOCRATIC REPUBLIC (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 130,Symbol=" ",Code = "EUR", Name = "Euro", Description = "LATVIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 131,Symbol=" ",Code = "LBP", Name = "Lebanese Pound", Description = "LEBANON", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 132,Symbol=" ",Code = "LSL", Name = "Loti", Description = "LESOTHO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 133,Symbol=" ",Code = "ZAR", Name = "Rand", Description = "LESOTHO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 134,Symbol=" ",Code = "LRD", Name = "Liberian Dollar", Description = "LIBERIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 135,Symbol=" ",Code = "LYD", Name = "Libyan Dinar", Description = "LIBYA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 136,Symbol=" ",Code = "CHF", Name = "Swiss Franc", Description = "LIECHTENSTEIN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 137,Symbol=" ",Code = "EUR", Name = "Euro", Description = "LITHUANIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 138,Symbol=" ",Code = "EUR", Name = "Euro", Description = "LUXEMBOURG", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 139,Symbol=" ",Code = "MOP", Name = "Pataca", Description = "MACAO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 140,Symbol=" ",Code = "MGA", Name = "Malagasy Ariary", Description = "MADAGASCAR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 141,Symbol=" ",Code = "MWK", Name = "Kwacha", Description = "MALAWI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 142,Symbol=" ",Code = "MYR", Name = "Malaysian Ringgit", Description = "MALAYSIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 143,Symbol=" ",Code = "MVR", Name = "Rufiyaa", Description = "MALDIVES", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 144,Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "MALI", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 145,Symbol=" ",Code = "EUR", Name = "Euro", Description = "MALTA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 146,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "MARSHALL ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 147,Symbol=" ",Code = "EUR", Name = "Euro", Description = "MARTINIQUE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 148,Symbol=" ",Code = "MRU", Name = "Ouguiya", Description = "MAURITANIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 149,Symbol=" ",Code = "MUR", Name = "Mauritius Rupee", Description = "MAURITIUS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 150,Symbol=" ",Code = "EUR", Name = "Euro", Description = "MAYOTTE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 151,Symbol=" ",Code = "MXN", Name = "Mexican Peso", Description = "MEXICO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 152,Symbol=" ",Code = "MXV", Name = "Mexican Unidad de Inversion (UDI)", Description = "MEXICO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 153,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "MICRONESIA (FEDERATED STATES OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 154,Symbol=" ",Code = "MDL", Name = "Moldovan Leu", Description = "MOLDOVA (THE REPUBLIC OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 155,Symbol=" ",Code = "EUR", Name = "Euro", Description = "MONACO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 156,Symbol=" ",Code = "MNT", Name = "Tugrik", Description = "MONGOLIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 157,Symbol=" ",Code = "EUR", Name = "Euro", Description = "MONTENEGRO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 158,Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "MONTSERRAT", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 159,Symbol=" ",Code = "MAD", Name = "Moroccan Dirham", Description = "MOROCCO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 160,Symbol=" ",Code = "MZN", Name = "Mozambique Metical", Description = "MOZAMBIQUE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 161,Symbol=" ",Code = "MMK", Name = "Kyat", Description = "MYANMAR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 162,Symbol=" ",Code = "NAD", Name = "Namibia Dollar", Description = "NAMIBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 163,Symbol=" ",Code = "ZAR", Name = "Rand", Description = "NAMIBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 164,Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "NAURU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 165,Symbol=" ",Code = "NPR", Name = "Nepalese Rupee", Description = "NEPAL", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 166,Symbol=" ",Code = "EUR", Name = "Euro", Description = "NETHERLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 167,Symbol=" ",Code = "XPF", Name = "CFP Franc", Description = "NEW CALEDONIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 168,Symbol=" ",Code = "NZD", Name = "New Zealand Dollar", Description = "NEW ZEALAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 169,Symbol=" ",Code = "NIO", Name = "Cordoba Oro", Description = "NICARAGUA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 170,Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "NIGER (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 171,Symbol=" ",Code = "NGN", Name = "Naira", Description = "NIGERIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 172,Symbol=" ",Code = "NZD", Name = "New Zealand Dollar", Description = "NIUE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 173,Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "NORFOLK ISLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 174,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "NORTHERN MARIANA ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 175,Symbol=" ",Code = "NOK", Name = "Norwegian Krone", Description = "NORWAY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 176,Symbol=" ",Code = "OMR", Name = "Rial Omani", Description = "OMAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 177,Symbol=" ",Code = "PKR", Name = "Pakistan Rupee", Description = "PAKISTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 178,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "PALAU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 179,Symbol=" ",Code = "PAB", Name = "Balboa", Description = "PANAMA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 180,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "PANAMA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 181,Symbol=" ",Code = "PGK", Name = "Kina", Description = "PAPUA NEW GUINEA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 182,Symbol=" ",Code = "PYG", Name = "Guarani", Description = "PARAGUAY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 183,Symbol=" ",Code = "PEN", Name = "Nuevo Sol", Description = "PERU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 184,Symbol=" ",Code = "PHP", Name = "Philippine Peso", Description = "PHILIPPINES (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 185,Symbol=" ",Code = "NZD", Name = "New Zealand Dollar", Description = "PITCAIRN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 186,Symbol=" ",Code = "PLN", Name = "Zloty", Description = "POLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 187,Symbol=" ",Code = "EUR", Name = "Euro", Description = "PORTUGAL", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 188,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "PUERTO RICO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 189,Symbol=" ",Code = "QAR", Name = "Qatari Rial", Description = "QATAR", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 190,Symbol=" ",Code = "MKD", Name = "Denar", Description = "REPUBLIC OF NORTH MACEDONIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 191,Symbol=" ",Code = "RON", Name = "Romanian Leu", Description = "ROMANIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 192,Symbol=" ",Code = "RUB", Name = "Russian Ruble", Description = "RUSSIAN FEDERATION (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 193,Symbol=" ",Code = "RWF", Name = "Rwanda Franc", Description = "RWANDA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 194,Symbol=" ",Code = "EUR", Name = "Euro", Description = "RÉUNION", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 195,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SAINT BARTHÉLEMY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 196,Symbol=" ",Code = "SHP", Name = "Saint Helena Pound", Description = "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 197,Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "SAINT KITTS AND NEVIS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 198,Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "SAINT LUCIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 199,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SAINT MARTIN (FRENCH PART)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 200,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SAINT PIERRE AND MIQUELON", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 201,Symbol=" ",Code = "XCD", Name = "East Caribbean Dollar", Description = "SAINT VINCENT AND THE GRENADINES", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 202,Symbol=" ",Code = "WST", Name = "Tala", Description = "SAMOA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 203,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SAN MARINO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 204,Symbol=" ",Code = "STN", Name = "Dobra", Description = "SAO TOME AND PRINCIPE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 205,Symbol=" ",Code = "SAR", Name = "Saudi Riyal", Description = "SAUDI ARABIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 206,Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "SENEGAL", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 207,Symbol=" ",Code = "RSD", Name = "Serbian Dinar", Description = "SERBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 208,Symbol=" ",Code = "SCR", Name = "Seychelles Rupee", Description = "SEYCHELLES", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 209,Symbol=" ",Code = "SLL", Name = "Leone", Description = "SIERRA LEONE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 210,Symbol=" ",Code = "SGD", Name = "Singapore Dollar", Description = "SINGAPORE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 211,Symbol=" ",Code = "ANG", Name = "Netherlands Antillean Guilder", Description = "SINT MAARTEN (DUTCH PART)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 212,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SLOVAKIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 213,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SLOVENIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 214,Symbol=" ",Code = "SBD", Name = "Solomon Islands Dollar", Description = "SOLOMON ISLANDS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 215,Symbol=" ",Code = "SOS", Name = "Somali Shilling", Description = "SOMALIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 216,Symbol=" ",Code = "ZAR", Name = "Rand", Description = "SOUTH AFRICA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 217,Symbol=" ",Code = "SSP", Name = "South Sudanese Pound", Description = "SOUTH SUDAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 218,Symbol=" ",Code = "EUR", Name = "Euro", Description = "SPAIN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 219,Symbol=" ",Code = "LKR", Name = "Sri Lanka Rupee", Description = "SRI LANKA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 220,Symbol=" ",Code = "SDG", Name = "Sudanese Pound", Description = "SUDAN (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 221,Symbol=" ",Code = "SRD", Name = "Surinam Dollar", Description = "SURINAME", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 222,Symbol=" ",Code = "NOK", Name = "Norwegian Krone", Description = "SVALBARD AND JAN MAYEN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 223,Symbol=" ",Code = "SZL", Name = "Lilangeni", Description = "SWAZILAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 224,Symbol=" ",Code = "SEK", Name = "Swedish Krona", Description = "SWEDEN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 225,Symbol=" ",Code = "CHE", Name = "WIR Euro", Description = "SWITZERLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 226,Symbol=" ",Code = "CHF", Name = "Swiss Franc", Description = "SWITZERLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 227,Symbol=" ",Code = "CHW", Name = "WIR Franc", Description = "SWITZERLAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 228,Symbol=" ",Code = "SYP", Name = "Syrian Pound", Description = "SYRIAN ARAB REPUBLIC", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 229,Symbol=" ",Code = "TWD", Name = "New Taiwan Dollar", Description = "TAIWAN (PROVINCE OF CHINA)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 230,Symbol=" ",Code = "TJS", Name = "Somoni", Description = "TAJIKISTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 231,Symbol=" ",Code = "TZS", Name = "Tanzanian Shilling", Description = "TANZANIA, UNITED REPUBLIC OF", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 232,Symbol=" ",Code = "THB", Name = "Baht", Description = "THAILAND", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 233,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "TIMOR-LESTE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 234,Symbol=" ",Code = "XOF", Name = "CFA Franc BCEAO", Description = "TOGO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 235,Symbol=" ",Code = "NZD", Name = "New Zealand Dollar", Description = "TOKELAU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 236,Symbol=" ",Code = "TOP", Name = "Pa’anga", Description = "TONGA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 237,Symbol=" ",Code = "TTD", Name = "Trinidad and Tobago Dollar", Description = "TRINIDAD AND TOBAGO", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 238,Symbol=" ",Code = "TND", Name = "Tunisian Dinar", Description = "TUNISIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 239,Symbol=" ",Code = "TRY", Name = "Turkish Lira", Description = "TURKEY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 240,Symbol=" ",Code = "TMT", Name = "Turkmenistan New Manat", Description = "TURKMENISTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 241,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "TURKS AND CAICOS ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 242,Symbol=" ",Code = "AUD", Name = "Australian Dollar", Description = "TUVALU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 243,Symbol=" ",Code = "UGX", Name = "Uganda Shilling", Description = "UGANDA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 244,Symbol=" ",Code = "UAH", Name = "Hryvnia", Description = "UKRAINE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 245,Symbol=" ",Code = "AED", Name = "UAE Dirham", Description = "UNITED ARAB EMIRATES (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 246,Symbol=" ",Code = "GBP", Name = "Pound Sterling", Description = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 247,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "UNITED STATES MINOR OUTLYING ISLANDS (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 248,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "UNITED STATES OF AMERICA (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 249,Symbol=" ",Code = "USN", Name = "US Dollar (Next day)", Description = "UNITED STATES OF AMERICA (THE)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 250,Symbol=" ",Code = "UYI", Name = "Uruguay Peso en Unidades Indexadas (URUIURUI)", Description = "URUGUAY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 251,Symbol=" ",Code = "UYU", Name = "Peso Uruguayo", Description = "URUGUAY", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 252,Symbol=" ",Code = "UZS", Name = "Uzbekistan Sum", Description = "UZBEKISTAN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 253,Symbol=" ",Code = "VUV", Name = "Vatu", Description = "VANUATU", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 254,Symbol=" ",Code = "VEF", Name = "Bolivar", Description = "VENEZUELA (BOLIVARIAN REPUBLIC OF)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 255,Symbol=" ",Code = "VND", Name = "Dong", Description = "VIET NAM", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 256,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "VIRGIN ISLANDS (BRITISH)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 257,Symbol=" ",Code = "USD", Name = "US Dollar", Description = "VIRGIN ISLANDS (U.S.)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 258,Symbol=" ",Code = "XPF", Name = "CFP Franc", Description = "WALLIS AND FUTUNA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 259,Symbol=" ",Code = "MAD", Name = "Moroccan Dirham", Description = "WESTERN SAHARA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 260,Symbol=" ",Code = "YER", Name = "Yemeni Rial", Description = "YEMEN", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 261,Symbol=" ",Code = "ZMW", Name = "Zambian Kwacha", Description = "ZAMBIA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 262,Symbol=" ",Code = "ZWL", Name = "Zimbabwe Dollar", Description = "ZIMBABWE", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Currency { Id = 263,Symbol=" ",Code = "EUR", Name = "Euro", Description = "ÅLAND ISLANDS", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }



                );
        }
    }
}
