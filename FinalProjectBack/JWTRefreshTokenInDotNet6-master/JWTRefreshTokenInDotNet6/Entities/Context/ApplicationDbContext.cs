using JWTRefreshTokenInDotNet6.Entities.Models;
using JWTRefreshTokenInDotNet6.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTRefreshTokenInDotNet6.Entities.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public virtual DbSet<AttendEvent> AttendEvents { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventRequest> EventRequests { get; set; }
        public virtual DbSet<EventSpeaker> EventSpeakers { get; set; }
        public virtual DbSet<Garage> Garages { get; set; }
        public virtual DbSet<HospitalRequest> HospitalRequests { get; set; }
        public virtual DbSet<Spot> Spots { get; set; }
        public virtual DbSet<StudentCertificateRequest> StudentCertificateRequests { get; set; }
        public virtual DbSet<SpotHistory> SpotHistories { get; set; }
        public virtual DbSet<EventSeats> EventSeats { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<HospitalCategory> HospitalCategories { get; set; }
        public virtual DbSet<HospitalCategoryDoctors> HospitalCategoryDoctors { get; set; }
        public virtual DbSet<BookHall> BookHalls { get; set; }
    }
}