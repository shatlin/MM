using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Event
    {
        public Event()
        {
            EventAccess = new HashSet<EventAccess>();
            EventAttendance = new HashSet<EventAttendance>();
            EventCommunication = new HashSet<EventCommunication>();
            EventEquipment = new HashSet<EventEquipment>();
            EventMinute = new HashSet<EventMinute>();
            EventPreRequisiteEventEvent = new HashSet<EventPreRequisiteEvent>();
            EventPreRequisiteEventPreRequisiteEvent = new HashSet<EventPreRequisiteEvent>();
            EventRegistration = new HashSet<EventRegistration>();
            EventRestrictionList = new HashSet<EventRestrictionList>();
            EventRole = new HashSet<EventRole>();
        }

        public int Id { get; set; }
        public string EventUniqueName { get; set; }
        public bool InternalOrExternal { get; set; }
        public int AddressId { get; set; }
        public int OrganizerId { get; set; }
        public string Title { get; set; }
        public int TimeZoneId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public DateTime RegStartDate { get; set; }
        public TimeSpan RegStartTime { get; set; }
        public DateTime RegEndDate { get; set; }
        public TimeSpan RegEndTime { get; set; }
        public int MaxRegistrationsAllowed { get; set; }
        public bool IsCpdevent { get; set; }
        public bool IsChargableEvent { get; set; }
        public bool ShowMaxRegistrationsAllowed { get; set; }
        public bool? AllowGuestRegistrations { get; set; }
        public int? GuestLimitPerRegistrant { get; set; }
        public bool AllowCancellations { get; set; }
        public int? CancellationbeforeDays { get; set; }
        public string Description { get; set; }
        public bool AllowRegistration { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Address Address { get; set; }
        public virtual ClientUser Organizer { get; set; }
        public virtual ClientTimeZone TimeZone { get; set; }
        public virtual ICollection<EventAccess> EventAccess { get; set; }
        public virtual ICollection<EventAttendance> EventAttendance { get; set; }
        public virtual ICollection<EventCommunication> EventCommunication { get; set; }
        public virtual ICollection<EventEquipment> EventEquipment { get; set; }
        public virtual ICollection<EventMinute> EventMinute { get; set; }
        public virtual ICollection<EventPreRequisiteEvent> EventPreRequisiteEventEvent { get; set; }
        public virtual ICollection<EventPreRequisiteEvent> EventPreRequisiteEventPreRequisiteEvent { get; set; }
        public virtual ICollection<EventRegistration> EventRegistration { get; set; }
        public virtual ICollection<EventRestrictionList> EventRestrictionList { get; set; }
        public virtual ICollection<EventRole> EventRole { get; set; }
    }
    public partial class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
  builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description).HasMaxLength(2000);

                builder.Property(e => e.EndDate).HasColumnType("datetime");

                builder.Property(e => e.EndTime).HasColumnType("time(2)");

                builder.Property(e => e.EventUniqueName)
                    .IsRequired()
                    .HasMaxLength(20);

                builder.Property(e => e.IsCpdevent).HasColumnName("IsCPDEvent");

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.RegEndDate).HasColumnType("datetime");

                builder.Property(e => e.RegEndTime).HasColumnType("time(2)");

                builder.Property(e => e.RegStartDate).HasColumnType("datetime");

                builder.Property(e => e.RegStartTime).HasColumnType("time(2)");

                builder.Property(e => e.StartDate).HasColumnType("datetime");

                builder.Property(e => e.StartTime).HasColumnType("time(2)");

                builder.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                builder.HasOne(d => d.Address)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Address");

                builder.HasOne(d => d.Organizer)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.OrganizerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_User");

                builder.HasOne(d => d.TimeZone)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TimeZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_TimeZone");
        }

    }
    public static partial class Seeder
    {
        public static void SeedEvent(this ModelBuilder modelBuilder)
        {

        }
    }
}
