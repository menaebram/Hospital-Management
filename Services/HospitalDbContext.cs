using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_Management.Models
{
    public class HospitalDbContext : IdentityDbContext<AppUsers>
    {
        public HospitalDbContext(DbContextOptions options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";
            var doctor = new IdentityRole("doctor");
            doctor.NormalizedName = "doctor";
            var nurse = new IdentityRole("nurse");
            nurse.NormalizedName = "nurse";
            var receiption = new IdentityRole("receiption");
            receiption.NormalizedName = "receiption";
            var pharmacist = new IdentityRole("pharmacist");
            pharmacist.NormalizedName = "pharmacist";
            var lab = new IdentityRole("lab");
            lab.NormalizedName = "lab";
            var accountant = new IdentityRole("accountant");
            accountant.NormalizedName = "accountant";
            var inventory = new IdentityRole("inventory");
            inventory.NormalizedName = "inventory";

            builder.Entity<IdentityRole>().HasData(admin, doctor, nurse, receiption, pharmacist, lab, accountant, inventory);
        }
    }
}
