using FutureEducationalPlatform.Domain.Entities.ExamEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.EntityConfiguration.HomeworkConfiguration
{
    public class HomeworkConfiguration : BaseConfiguration<Homework>
    {
        public override void Configure(EntityTypeBuilder<Homework> builder)
        {
            base.Configure(builder);
            builder.Property(h => h.IsActive).HasDefaultValue(true);
            builder.Property(h => h.Name).HasMaxLength(128);
        }
    }
}
