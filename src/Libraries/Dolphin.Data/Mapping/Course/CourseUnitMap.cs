﻿using Dolphin.Core.Domain.Course;
using System.Data.Entity.ModelConfiguration;

namespace Dolphin.Data.Mapping.Course
{
    public class CourseUnitMap : EntityTypeConfiguration<CourseUnit>
    {
        public CourseUnitMap()
        {
            this.ToTable("CourseUnit");
            this.HasKey(cu => cu.Id);
            this.Property(cu => cu.Id).HasColumnName("CourseUnit_id");
            this.Property(cu => cu.No).HasColumnName("UnitNo");
            this.Property(cu => cu.Name).HasColumnName("UnitName");
            this.Property(cu => cu.Description).HasColumnName("UnitDescr");
            this.Property(cu => cu.ImageUrl).HasColumnName("UnitImageUrl");
        }
    }
}