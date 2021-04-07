using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MummyProject.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Age",
                columns: table => new
                {
                    age_code = table.Column<long>(nullable: false),
                    age_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Age", x => x.age_code);
                });

            migrationBuilder.CreateTable(
                name: "Burial",
                columns: table => new
                {
                    burial_id = table.Column<long>(nullable: false),
                    burial_location_ns = table.Column<string>(nullable: true),
                    burial_location_ew = table.Column<string>(nullable: true),
                    low_pair_ns = table.Column<long>(nullable: true),
                    high_pair_ns = table.Column<byte[]>(nullable: true),
                    low_pair_ew = table.Column<long>(nullable: true),
                    high_pair_ew = table.Column<long>(nullable: true),
                    burial_subplot = table.Column<string>(nullable: true),
                    burial_depth = table.Column<double>(nullable: true),
                    south_to_head = table.Column<double>(nullable: true),
                    south_to_feet = table.Column<double>(nullable: true),
                    east_to_head = table.Column<double>(nullable: true),
                    east_to_feet = table.Column<double>(nullable: true),
                    gender_ge = table.Column<string>(nullable: true),
                    age_estimate = table.Column<long>(nullable: true),
                    length_of_remains = table.Column<double>(nullable: true),
                    burial_number = table.Column<long>(nullable: true),
                    sample_number = table.Column<long>(nullable: true),
                    ge_function_total = table.Column<double>(nullable: true),
                    gender_body_col = table.Column<string>(nullable: true),
                    basilar_suture = table.Column<double>(nullable: true),
                    ventral_arc = table.Column<double>(nullable: true),
                    subpubic_angle = table.Column<double>(nullable: true),
                    sciatic_notch = table.Column<double>(nullable: true),
                    pubic_bone = table.Column<double>(nullable: true),
                    preaur_sulcus = table.Column<double>(nullable: true),
                    medial_ip_ramus = table.Column<double>(nullable: true),
                    dorsal_pitting = table.Column<double>(nullable: true),
                    foreman_magnum = table.Column<double>(nullable: true),
                    femur_head = table.Column<double>(nullable: true),
                    humerus_head = table.Column<double>(nullable: true),
                    osteophytosis = table.Column<string>(nullable: true),
                    pubic_symphysis = table.Column<string>(nullable: true),
                    bone_length = table.Column<double>(nullable: true),
                    medial_clavicle = table.Column<double>(nullable: true),
                    ilac_crest = table.Column<double>(nullable: true),
                    femur_diameter = table.Column<double>(nullable: true),
                    humerus = table.Column<double>(nullable: true),
                    femur_length = table.Column<double>(nullable: true),
                    humerus_length = table.Column<double>(nullable: true),
                    tibia_length = table.Column<double>(nullable: true),
                    robust = table.Column<double>(nullable: true),
                    supraorbital_ridges = table.Column<double>(nullable: true),
                    orbit_edge = table.Column<double>(nullable: true),
                    parietal_bossing = table.Column<double>(nullable: true),
                    gonian = table.Column<double>(nullable: true),
                    nuchal_crest = table.Column<double>(nullable: true),
                    zygomatic_crest = table.Column<double>(nullable: true),
                    cranial_suture = table.Column<string>(nullable: true),
                    maximum_cranial_length = table.Column<double>(nullable: true),
                    maximum_cranial_breadth = table.Column<double>(nullable: true),
                    basion_bregma_height = table.Column<double>(nullable: true),
                    basion_nasion = table.Column<double>(nullable: true),
                    basion_prosthion_length = table.Column<double>(nullable: true),
                    bizygomatic_diameter = table.Column<double>(nullable: true),
                    nasion_prosthion = table.Column<double>(nullable: true),
                    maximum_nasal_breadth = table.Column<double>(nullable: true),
                    interorbital_breadth = table.Column<double>(nullable: true),
                    artifact_description = table.Column<string>(nullable: true),
                    hair_color = table.Column<string>(nullable: true),
                    presevation_index = table.Column<string>(nullable: true),
                    hair_taken = table.Column<long>(nullable: true),
                    soft_tissue_taken = table.Column<long>(nullable: true),
                    bone_taken = table.Column<long>(nullable: true),
                    tooth_taken = table.Column<long>(nullable: true),
                    textile_taken = table.Column<long>(nullable: true),
                    description_of_taken = table.Column<string>(nullable: true),
                    artifact_found = table.Column<long>(nullable: true),
                    estimate_living_stature = table.Column<double>(nullable: true),
                    tooth_attrition = table.Column<string>(nullable: true),
                    tooth_eruption = table.Column<string>(nullable: true),
                    pathology_anomolies = table.Column<string>(nullable: true),
                    epiphyseal_union = table.Column<long>(nullable: true),
                    year_found = table.Column<long>(nullable: true),
                    month_found = table.Column<string>(nullable: true),
                    day_found = table.Column<long>(nullable: true),
                    head_direction = table.Column<string>(nullable: true),
                    wrapping_code = table.Column<long>(nullable: true),
                    age_code = table.Column<long>(nullable: true),
                    sex_method = table.Column<string>(nullable: true),
                    age_method = table.Column<string>(nullable: true),
                    photo_id = table.Column<long>(nullable: true),
                    rack = table.Column<string>(nullable: true),
                    shelf = table.Column<string>(nullable: true),
                    field_notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burial", x => x.burial_id);
                });

            migrationBuilder.CreateTable(
                name: "Wrapping",
                columns: table => new
                {
                    wrapping_code = table.Column<long>(nullable: false),
                    wrapping_description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wrapping", x => x.wrapping_code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Age");

            migrationBuilder.DropTable(
                name: "Burial");

            migrationBuilder.DropTable(
                name: "Wrapping");
        }
    }
}
