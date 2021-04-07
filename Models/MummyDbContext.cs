using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MummyProject.Models
{
    public partial class MummyDbContext : DbContext
    {
        public MummyDbContext()
        {
        }

        public MummyDbContext(DbContextOptions<MummyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Age> Age { get; set; }
        public virtual DbSet<Burial> Burial { get; set; }
        public virtual DbSet<Wrapping> Wrapping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source = MummyDb.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Age>(entity =>
            {
                entity.HasKey(e => e.AgeCode);

                entity.Property(e => e.AgeCode)
                    .HasColumnName("age_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeDescription).HasColumnName("age_description");
            });

            modelBuilder.Entity<Burial>(entity =>
            {
                entity.Property(e => e.BurialId)
                    .HasColumnName("burial_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeCode).HasColumnName("age_code");

                entity.Property(e => e.AgeEstimate).HasColumnName("age_estimate");

                entity.Property(e => e.AgeMethod).HasColumnName("age_method");

                entity.Property(e => e.ArtifactDescription).HasColumnName("artifact_description");

                entity.Property(e => e.ArtifactFound).HasColumnName("artifact_found");

                entity.Property(e => e.BasilarSuture).HasColumnName("basilar_suture");

                entity.Property(e => e.BasionBregmaHeight).HasColumnName("basion_bregma_height");

                entity.Property(e => e.BasionNasion).HasColumnName("basion_nasion");

                entity.Property(e => e.BasionProsthionLength).HasColumnName("basion_prosthion_length");

                entity.Property(e => e.BizygomaticDiameter).HasColumnName("bizygomatic_diameter");

                entity.Property(e => e.BoneLength).HasColumnName("bone_length");

                entity.Property(e => e.BoneTaken).HasColumnName("bone_taken");

                entity.Property(e => e.BurialDepth).HasColumnName("burial_depth");

                entity.Property(e => e.BurialLocationEw).HasColumnName("burial_location_ew");

                entity.Property(e => e.BurialLocationNs).HasColumnName("burial_location_ns");

                entity.Property(e => e.BurialNumber).HasColumnName("burial_number");

                entity.Property(e => e.BurialSubplot).HasColumnName("burial_subplot");

                entity.Property(e => e.CranialSuture).HasColumnName("cranial_suture");

                entity.Property(e => e.DayFound).HasColumnName("day_found");

                entity.Property(e => e.DescriptionOfTaken).HasColumnName("description_of_taken");

                entity.Property(e => e.DorsalPitting).HasColumnName("dorsal_pitting");

                entity.Property(e => e.EastToFeet).HasColumnName("east_to_feet");

                entity.Property(e => e.EastToHead).HasColumnName("east_to_head");

                entity.Property(e => e.EpiphysealUnion).HasColumnName("epiphyseal_union");

                entity.Property(e => e.EstimateLivingStature).HasColumnName("estimate_living_stature");

                entity.Property(e => e.FemurDiameter).HasColumnName("femur_diameter");

                entity.Property(e => e.FemurHead).HasColumnName("femur_head");

                entity.Property(e => e.FemurLength).HasColumnName("femur_length");

                entity.Property(e => e.FieldNotes).HasColumnName("field_notes");

                entity.Property(e => e.ForemanMagnum).HasColumnName("foreman_magnum");

                entity.Property(e => e.GeFunctionTotal).HasColumnName("ge_function_total");

                entity.Property(e => e.GenderBodyCol).HasColumnName("gender_body_col");

                entity.Property(e => e.GenderGe).HasColumnName("gender_ge");

                entity.Property(e => e.Gonian).HasColumnName("gonian");

                entity.Property(e => e.HairColor).HasColumnName("hair_color");

                entity.Property(e => e.HairTaken).HasColumnName("hair_taken");

                entity.Property(e => e.HeadDirection).HasColumnName("head_direction");

                entity.Property(e => e.HighPairEw).HasColumnName("high_pair_ew");

                entity.Property(e => e.HighPairNs).HasColumnName("high_pair_ns");

                entity.Property(e => e.Humerus).HasColumnName("humerus");

                entity.Property(e => e.HumerusHead).HasColumnName("humerus_head");

                entity.Property(e => e.HumerusLength).HasColumnName("humerus_length");

                entity.Property(e => e.IlacCrest).HasColumnName("ilac_crest");

                entity.Property(e => e.InterorbitalBreadth).HasColumnName("interorbital_breadth");

                entity.Property(e => e.LengthOfRemains).HasColumnName("length_of_remains");

                entity.Property(e => e.LowPairEw).HasColumnName("low_pair_ew");

                entity.Property(e => e.LowPairNs).HasColumnName("low_pair_ns");

                entity.Property(e => e.MaximumCranialBreadth).HasColumnName("maximum_cranial_breadth");

                entity.Property(e => e.MaximumCranialLength).HasColumnName("maximum_cranial_length");

                entity.Property(e => e.MaximumNasalBreadth).HasColumnName("maximum_nasal_breadth");

                entity.Property(e => e.MedialClavicle).HasColumnName("medial_clavicle");

                entity.Property(e => e.MedialIpRamus).HasColumnName("medial_ip_ramus");

                entity.Property(e => e.MonthFound).HasColumnName("month_found");

                entity.Property(e => e.NasionProsthion).HasColumnName("nasion_prosthion");

                entity.Property(e => e.NuchalCrest).HasColumnName("nuchal_crest");

                entity.Property(e => e.OrbitEdge).HasColumnName("orbit_edge");

                entity.Property(e => e.Osteophytosis).HasColumnName("osteophytosis");

                entity.Property(e => e.ParietalBossing).HasColumnName("parietal_bossing");

                entity.Property(e => e.PathologyAnomolies).HasColumnName("pathology_anomolies");

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.PreaurSulcus).HasColumnName("preaur_sulcus");

                entity.Property(e => e.PresevationIndex).HasColumnName("presevation_index");

                entity.Property(e => e.PubicBone).HasColumnName("pubic_bone");

                entity.Property(e => e.PubicSymphysis).HasColumnName("pubic_symphysis");

                entity.Property(e => e.Rack).HasColumnName("rack");

                entity.Property(e => e.Robust).HasColumnName("robust");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.Property(e => e.SciaticNotch).HasColumnName("sciatic_notch");

                entity.Property(e => e.SexMethod).HasColumnName("sex_method");

                entity.Property(e => e.Shelf).HasColumnName("shelf");

                entity.Property(e => e.SoftTissueTaken).HasColumnName("soft_tissue_taken");

                entity.Property(e => e.SouthToFeet).HasColumnName("south_to_feet");

                entity.Property(e => e.SouthToHead).HasColumnName("south_to_head");

                entity.Property(e => e.SubpubicAngle).HasColumnName("subpubic_angle");

                entity.Property(e => e.SupraorbitalRidges).HasColumnName("supraorbital_ridges");

                entity.Property(e => e.TextileTaken).HasColumnName("textile_taken");

                entity.Property(e => e.TibiaLength).HasColumnName("tibia_length");

                entity.Property(e => e.ToothAttrition).HasColumnName("tooth_attrition");

                entity.Property(e => e.ToothEruption).HasColumnName("tooth_eruption");

                entity.Property(e => e.ToothTaken).HasColumnName("tooth_taken");

                entity.Property(e => e.VentralArc).HasColumnName("ventral_arc");

                entity.Property(e => e.WrappingCode).HasColumnName("wrapping_code");

                entity.Property(e => e.YearFound).HasColumnName("year_found");

                entity.Property(e => e.ZygomaticCrest).HasColumnName("zygomatic_crest");
            });

            modelBuilder.Entity<Wrapping>(entity =>
            {
                entity.HasKey(e => e.WrappingCode);

                entity.Property(e => e.WrappingCode)
                    .HasColumnName("wrapping_code")
                    .ValueGeneratedNever();

                entity.Property(e => e.WrappingDescription).HasColumnName("wrapping_description");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
