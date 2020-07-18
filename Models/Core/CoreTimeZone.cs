using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreTimeZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }

    public partial class CoreTimeZoneConfiguration : IEntityTypeConfiguration<CoreTimeZone>
    {
        public void Configure(EntityTypeBuilder<CoreTimeZone> builder)
        {

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");
            builder.Property(e => e.Description).HasMaxLength(200);
            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
        }
    }

    public static partial class Seeder
    {
        public static void SeedCoreTimeZone(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreTimeZone>().HasData(
                        new CoreTimeZone { Id = 1, Name = "Dateline Standard Time", Description = "(GMT-12:00) International Date Line West", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 2, Name = "Samoa Standard Time", Description = "(GMT-11:00) MIdway Island, Samoa", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 3, Name = "Hawaiian Standard Time", Description = "(GMT-10:00) Hawaii", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 4, Name = "Alaskan Standard Time", Description = "(GMT-09:00) Alaska", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 5, Name = "Pacific Standard Time", Description = "(GMT-08:00) Pacific Time (US and Canada); Tijuana", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 6, Name = "Mountain Standard Time", Description = "(GMT-07:00) Mountain Time (US and Canada)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 7, Name = "Mexico Standard Time 2", Description = "(GMT-07:00) Chihuahua, La Paz, Mazatlan", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 8, Name = "U.S. Mountain Standard Time", Description = "(GMT-07:00) Arizona", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 9, Name = "Central Standard Time", Description = "(GMT-06:00) Central Time (US and Canada)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 10, Name = "Canada Central Standard Time", Description = "(GMT-06:00) Saskatchewan", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 11, Name = "Mexico Standard Time", Description = "(GMT-06:00) Guadalajara, Mexico City, Monterrey", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 12, Name = "Central America Standard Time", Description = "(GMT-06:00) Central America", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 13, Name = "Eastern Standard Time", Description = "(GMT-05:00) Eastern Time (US and Canada)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 14, Name = "U.S. Eastern Standard Time", Description = "(GMT-05:00) Indiana (East)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 15, Name = "S.A. Pacific Standard Time", Description = "(GMT-05:00) Bogota, Lima, Quito", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 16, Name = "Atlantic Standard Time", Description = "(GMT-04:00) Atlantic Time (Canada)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 17, Name = "S.A. Western Standard Time", Description = "(GMT-04:00) Georgetown, La Paz, San Juan", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 18, Name = "Pacific S.A. Standard Time", Description = "(GMT-04:00) Santiago", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 19, Name = "Newfoundland and Labrador Standard Time", Description = "(GMT-03:30) Newfoundland", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 20, Name = "E. South America Standard Time", Description = "(GMT-03:00) Brasilia", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 21, Name = "S.A. Eastern Standard Time", Description = "(GMT-03:00) Georgetown", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 22, Name = "Greenland Standard Time", Description = "(GMT-03:00) Greenland", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 23, Name = "MId-Atlantic Standard Time", Description = "(GMT-02:00) MId-Atlantic", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 24, Name = "Azores Standard Time", Description = "(GMT-01:00) Azores", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 25, Name = "Cape Verde Standard Time", Description = "(GMT-01:00) Cape Verde Islands", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 26, Name = "GMT Standard Time", Description = "(GMT) Greenwich Mean Time: Dublin, Edinburgh, Lisbon, London", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 27, Name = "Greenwich Standard Time", Description = "(GMT) Monrovia, Reykjavik", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 28, Name = "Central Europe Standard Time", Description = "(GMT+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 29, Name = "Central European Standard Time", Description = "(GMT+01:00) Sarajevo, Skopje, Warsaw, Zagreb", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 30, Name = "Romance Standard Time", Description = "(GMT+01:00) Brussels, Copenhagen, MadrId, Paris", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 31, Name = "W. Europe Standard Time", Description = "(GMT+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 32, Name = "W. Central Africa Standard Time", Description = "(GMT+01:00) West Central Africa", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 33, Name = "E. Europe Standard Time", Description = "(GMT+02:00) Minsk", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 34, Name = "Egypt Standard Time", Description = "(GMT+02:00) Cairo", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 35, Name = "FLE Standard Time", Description = "(GMT+02:00) Helsinki, Kiev, Riga, Sofia, Tallinn, Vilnius", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 36, Name = "GTB Standard Time", Description = "(GMT+02:00) Athens, Bucharest, Istanbul", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 37, Name = "Israel Standard Time", Description = "(GMT+02:00) Jerusalem", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 38, Name = "South Africa Standard Time", Description = "(GMT+02:00) Harare, Pretoria", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 39, Name = "Russian Standard Time", Description = "(GMT+03:00) Moscow, St. Petersburg, Volgograd", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 40, Name = "Arab Standard Time", Description = "(GMT+03:00) Kuwait, Riyadh", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 41, Name = "E. Africa Standard Time", Description = "(GMT+03:00) Nairobi", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 42, Name = "Arabic Standard Time", Description = "(GMT+03:00) Baghdad", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 43, Name = "Iran Standard Time", Description = "(GMT+03:30) Tehran", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 44, Name = "Arabian Standard Time", Description = "(GMT+04:00) Abu Dhabi, Muscat", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 45, Name = "Caucasus Standard Time", Description = "(GMT+04:00) Baku, Tbilisi, Yerevan", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 46, Name = "Transitional Islamic State of Afghanistan Standard Time", Description = "(GMT+04:30) Kabul", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 47, Name = "Ekaterinburg Standard Time", Description = "(GMT+05:00) Ekaterinburg", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 48, Name = "West Asia Standard Time", Description = "(GMT+05:00) Tashkent", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 49, Name = "India Standard Time", Description = "(GMT+05:30) Chennai, Kolkata, Mumbai, New Delhi", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 50, Name = "Nepal Standard Time", Description = "(GMT+05:45) Kathmandu", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 51, Name = "Central Asia Standard Time", Description = "(GMT+06:00) Astana, Dhaka", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 52, Name = "Sri Lanka Standard Time", Description = "(GMT+06:00) Sri Jayawardenepura", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 53, Name = "N. Central Asia Standard Time", Description = "(GMT+06:00) Almaty, Novosibirsk", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 54, Name = "Myanmar Standard Time", Description = "(GMT+06:30) Yangon (Rangoon)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 55, Name = "S.E. Asia Standard Time", Description = "(GMT+07:00) Bangkok, Hanoi, Jakarta", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 56, Name = "North Asia Standard Time", Description = "(GMT+07:00) Krasnoyarsk", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 57, Name = "China Standard Time", Description = "(GMT+08:00) Beijing, Chongqing, Hong Kong, Urumqi", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 58, Name = "Singapore Standard Time", Description = "(GMT+08:00) Kuala Lumpur, Singapore", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 59, Name = "Taipei Standard Time", Description = "(GMT+08:00) Taipei", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 60, Name = "W. Australia Standard Time", Description = "(GMT+08:00) Perth", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 61, Name = "North Asia East Standard Time", Description = "(GMT+08:00) Irkutsk, Ulaanbaatar", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 62, Name = "Korea Standard Time", Description = "(GMT+09:00) Seoul", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 63, Name = "Tokyo Standard Time", Description = "(GMT+09:00) Osaka, Sapporo, Tokyo", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 64, Name = "Yakutsk Standard Time", Description = "(GMT+09:00) Yakutsk", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 65, Name = "A.U.S. Central Standard Time", Description = "(GMT+09:30) Darwin", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 66, Name = "Cen. Australia Standard Time", Description = "(GMT+09:30) AdelaIde", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 67, Name = "A.U.S. Eastern Standard Time", Description = "(GMT+10:00) Canberra, Melbourne, Sydney", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 68, Name = "E. Australia Standard Time", Description = "(GMT+10:00) Brisbane", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 69, Name = "Tasmania Standard Time", Description = "(GMT+10:00) Hobart", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 70, Name = "Vladivostok Standard Time", Description = "(GMT+10:00) Vladivostok", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 71, Name = "West Pacific Standard Time", Description = "(GMT+10:00) Guam, Port Moresby", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 72, Name = "Central Pacific Standard Time", Description = "(GMT+11:00) Magadan, Solomon Islands, New Caledonia", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 73, Name = "Fiji Islands Standard Time", Description = "(GMT+12:00) Fiji, Kamchatka, Marshall Is.", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 74, Name = "New Zealand Standard Time", Description = "(GMT+12:00) Auckland, Wellington", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 75, Name = "Tonga Standard Time", Description = "(GMT+13:00) Nuku'alofa", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 76, Name = "Azerbaijan Standard Time ", Description = "(GMT-03:00) Buenos Aires", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 77, Name = "MIddle East Standard Time", Description = "(GMT+02:00) Beirut", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 78, Name = "Jordan Standard Time", Description = "(GMT+02:00) Amman", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 79, Name = "Central Standard Time (Mexico)", Description = "(GMT-06:00) Guadalajara, Mexico City, Monterrey - New", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 80, Name = "Mountain Standard Time (Mexico)", Description = "(GMT-07:00) Chihuahua, La Paz, Mazatlan - New", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 81, Name = "Pacific Standard Time (Mexico)", Description = "(GMT-08:00) Tijuana, Baja California", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 82, Name = "Namibia Standard Time", Description = "(GMT+02:00) Windhoek", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 83, Name = "Georgian Standard Time", Description = "(GMT+03:00) Tbilisi", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 84, Name = "Central Brazilian Standard Time", Description = "(GMT-04:00) Manaus", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 85, Name = "MontevIdeo Standard Time", Description = "(GMT-03:00) MontevIdeo", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 86, Name = "Armenian Standard Time", Description = "(GMT+04:00) Yerevan", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 87, Name = "Venezuela Standard Time", Description = "(GMT-04:30) Caracas", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 88, Name = "Argentina Standard Time", Description = "(GMT-03:00) Buenos Aires", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 89, Name = "Morocco Standard Time", Description = "(GMT) Casablanca", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 90, Name = "Pakistan Standard Time", Description = "(GMT+05:00) Islamabad, Karachi", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 91, Name = "Mauritius Standard Time", Description = "(GMT+04:00) Port Louis", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 92, Name = "UTC", Description = "(GMT) Coordinated Universal Time", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 93, Name = "Paraguay Standard Time", Description = "(GMT-04:00) Asuncion", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                        new CoreTimeZone { Id = 94, Name = "Kamchatka Standard Time", Description = "(GMT+12:00) Petropavlovsk-Kamchatsky", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }

                 );

        }
    }

}
