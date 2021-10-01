using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ErpSystem
{
    public partial class ErpSystemContext : DbContext
    {
        public ErpSystemContext()
            : base("name=ErpSystemContext")
        {
        }

        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<company_address> company_address { get; set; }
        public virtual DbSet<company_field_of_work> company_field_of_work { get; set; }
        public virtual DbSet<company_name> company_name { get; set; }
        public virtual DbSet<company_telephone> company_telephone { get; set; }
        public virtual DbSet<contact_person_info> contact_person_info { get; set; }
        public virtual DbSet<contact_person_mobile> contact_person_mobile { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<departments_type> departments_type { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<educational_degrees> educational_degrees { get; set; }
        public virtual DbSet<educational_majors> educational_majors { get; set; }
        public virtual DbSet<employees_business_emails> employees_business_emails { get; set; }
        public virtual DbSet<employees_info> employees_info { get; set; }
        public virtual DbSet<employees_passwords> employees_passwords { get; set; }
        public virtual DbSet<employees_personal_emails> employees_personal_emails { get; set; }
        public virtual DbSet<generic_work_fields> generic_work_fields { get; set; }
        public virtual DbSet<positions_type> positions_type { get; set; }
        public virtual DbSet<specific_work_fields> specific_work_fields { get; set; }
        public virtual DbSet<states_governorates> states_governorates { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<teams_type> teams_type { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<city>()
                .Property(e => e.city1)
                .IsUnicode(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.districts)
                .WithOptional(e => e.city1)
                .HasForeignKey(e => e.city);

            modelBuilder.Entity<company_address>()
                .HasMany(e => e.company_telephone)
                .WithRequired(e => e.company_address)
                .HasForeignKey(e => e.branch_serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<company_address>()
                .HasMany(e => e.contact_person_info)
                .WithRequired(e => e.company_address)
                .HasForeignKey(e => e.branch_serial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<company_name>()
                .Property(e => e.company_name1)
                .IsUnicode(false);

            modelBuilder.Entity<company_name>()
                .HasOptional(e => e.company_field_of_work)
                .WithRequired(e => e.company_name);

            modelBuilder.Entity<company_telephone>()
                .Property(e => e.telephone_number)
                .IsUnicode(false);

            modelBuilder.Entity<contact_person_info>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<contact_person_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<contact_person_info>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<contact_person_info>()
                .HasMany(e => e.contact_person_mobile)
                .WithRequired(e => e.contact_person_info)
                .HasForeignKey(e => new { e.sales_person_id, e.branch_serial, e.contact_id })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<contact_person_mobile>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.country1)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .HasMany(e => e.states_governorates)
                .WithOptional(e => e.country1)
                .HasForeignKey(e => e.country);

            modelBuilder.Entity<departments_type>()
                .Property(e => e.department)
                .IsUnicode(false);

            modelBuilder.Entity<departments_type>()
                .HasMany(e => e.contact_person_info)
                .WithOptional(e => e.departments_type)
                .HasForeignKey(e => e.department);

            modelBuilder.Entity<departments_type>()
                .HasMany(e => e.employees_info)
                .WithOptional(e => e.departments_type)
                .HasForeignKey(e => e.employee_department);

            modelBuilder.Entity<district>()
                .Property(e => e.district1)
                .IsUnicode(false);

            modelBuilder.Entity<district>()
                .HasMany(e => e.company_address)
                .WithOptional(e => e.district)
                .HasForeignKey(e => e.address);

            modelBuilder.Entity<educational_degrees>()
                .Property(e => e.educational_degree)
                .IsUnicode(false);

            modelBuilder.Entity<educational_majors>()
                .Property(e => e.educational_major)
                .IsUnicode(false);

            modelBuilder.Entity<employees_business_emails>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<employees_info>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<employees_info>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<employees_info>()
                .HasMany(e => e.company_address)
                .WithOptional(e => e.employees_info)
                .HasForeignKey(e => e.added_by);

            modelBuilder.Entity<employees_info>()
                .HasMany(e => e.company_field_of_work)
                .WithOptional(e => e.employees_info)
                .HasForeignKey(e => e.added_by);

            modelBuilder.Entity<employees_info>()
                .HasMany(e => e.company_name)
                .WithOptional(e => e.employees_info)
                .HasForeignKey(e => e.added_by);

            modelBuilder.Entity<employees_info>()
                .HasMany(e => e.company_telephone)
                .WithOptional(e => e.employees_info)
                .HasForeignKey(e => e.added_by);

            modelBuilder.Entity<employees_info>()
                .HasMany(e => e.contact_person_info)
                .WithRequired(e => e.employees_info)
                .HasForeignKey(e => e.sales_person_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employees_info>()
                .HasOptional(e => e.employees_business_emails)
                .WithRequired(e => e.employees_info);

            modelBuilder.Entity<employees_info>()
                .HasOptional(e => e.employees_passwords)
                .WithRequired(e => e.employees_info);

            modelBuilder.Entity<employees_info>()
                .HasOptional(e => e.employees_personal_emails)
                .WithRequired(e => e.employees_info);

            modelBuilder.Entity<employees_passwords>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<employees_personal_emails>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<generic_work_fields>()
                .Property(e => e.generic_work_field)
                .IsUnicode(false);

            modelBuilder.Entity<generic_work_fields>()
                .HasMany(e => e.specific_work_fields)
                .WithOptional(e => e.generic_work_fields)
                .HasForeignKey(e => e.generic_work_field);

            modelBuilder.Entity<positions_type>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<positions_type>()
                .HasMany(e => e.employees_info)
                .WithOptional(e => e.positions_type)
                .HasForeignKey(e => e.employee_position);

            modelBuilder.Entity<specific_work_fields>()
                .Property(e => e.specific_work_field)
                .IsUnicode(false);

            modelBuilder.Entity<specific_work_fields>()
                .HasMany(e => e.company_field_of_work)
                .WithOptional(e => e.specific_work_fields)
                .HasForeignKey(e => e.work_field);

            modelBuilder.Entity<states_governorates>()
                .Property(e => e.state_governorate)
                .IsUnicode(false);

            modelBuilder.Entity<states_governorates>()
                .HasMany(e => e.cities)
                .WithOptional(e => e.states_governorates)
                .HasForeignKey(e => e.state_governorate);

            modelBuilder.Entity<teams_type>()
                .Property(e => e.team)
                .IsUnicode(false);

            modelBuilder.Entity<teams_type>()
                .HasMany(e => e.employees_info)
                .WithOptional(e => e.teams_type)
                .HasForeignKey(e => e.employee_team);
        }
    }
}
