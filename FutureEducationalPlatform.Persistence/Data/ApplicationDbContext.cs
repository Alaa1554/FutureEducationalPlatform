using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using FutureEducationalPlatform.Domain.Entities.ExamEntites;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using FutureEducationalPlatform.Persistence.EntityConfiguration.CenterEntitesConfiguration;
using FutureEducationalPlatform.Persistence.EntityConfiguration.CourseEntitesConfiguration;
using FutureEducationalPlatform.Persistence.EntityConfiguration.HomeworkConfiguration;
using FutureEducationalPlatform.Persistence.EntityConfiguration.QuestionEntitesConfiguration;
using FutureEducationalPlatform.Persistence.EntityConfiguration.UserEntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
        modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        modelBuilder.ApplyConfiguration(new AdminConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
        modelBuilder.ApplyConfiguration(new ParentConfiguration());
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        modelBuilder.ApplyConfiguration(new CenterConfiguration());
        modelBuilder.ApplyConfiguration(new CenterCourseTimeConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CourseSectionConfiguration());
        modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<SuperAdmin> SuperAdmins { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Center> Centers { get; set; }
    public DbSet<CenterCourseTime> CentersCourseTime { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<CourseSection> CourseSections { get; set; }
    public DbSet<Homework> Homeworks { get; set; }

}

