using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MarioKart7Builder.Models;

namespace MarioKart7Builder.Migrations
{
    [DbContext(typeof(MarioKart7BuilderContext))]
    [Migration("20170726225139_then2")]
    partial class then2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarioKart7Builder.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Body", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acceleration");

                    b.Property<int>("airHandling");

                    b.Property<int>("airSpeed");

                    b.Property<int>("drift");

                    b.Property<int>("landHandling");

                    b.Property<int>("landSpeed");

                    b.Property<int>("miniTurbo");

                    b.Property<string>("name");

                    b.Property<int>("offRoad");

                    b.Property<int>("stabiliy");

                    b.Property<int>("waterSpeed");

                    b.Property<int>("watrHandling");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("bodys");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acceleration");

                    b.Property<int>("airHandling");

                    b.Property<int>("airSpeed");

                    b.Property<int>("drift");

                    b.Property<int>("landHandling");

                    b.Property<int>("landSpeed");

                    b.Property<int>("miniTurbo");

                    b.Property<string>("name");

                    b.Property<int>("offRoad");

                    b.Property<int>("stabiliy");

                    b.Property<int>("waterSpeed");

                    b.Property<int>("watrHandling");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Glider", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acceleration");

                    b.Property<int>("airHandling");

                    b.Property<int>("airSpeed");

                    b.Property<int>("drift");

                    b.Property<int>("landHandling");

                    b.Property<int>("landSpeed");

                    b.Property<int>("miniTurbo");

                    b.Property<string>("name");

                    b.Property<int>("offRoad");

                    b.Property<int>("stabiliy");

                    b.Property<int>("waterSpeed");

                    b.Property<int>("watrHandling");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("gliders");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Kart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("bodyid");

                    b.Property<int?>("characterid");

                    b.Property<int?>("gliderid");

                    b.Property<string>("name");

                    b.Property<int?>("tireid");

                    b.Property<string>("userId");

                    b.HasKey("id");

                    b.HasIndex("bodyid");

                    b.HasIndex("characterid");

                    b.HasIndex("gliderid");

                    b.HasIndex("tireid");

                    b.ToTable("karts");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Tire", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("acceleration");

                    b.Property<int>("airHandling");

                    b.Property<int>("airSpeed");

                    b.Property<int>("drift");

                    b.Property<int>("landHandling");

                    b.Property<int>("landSpeed");

                    b.Property<int>("miniTurbo");

                    b.Property<string>("name");

                    b.Property<int>("offRoad");

                    b.Property<int>("stabiliy");

                    b.Property<int>("waterSpeed");

                    b.Property<int>("watrHandling");

                    b.Property<int>("weight");

                    b.HasKey("id");

                    b.ToTable("tires");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MarioKart7Builder.Models.Kart", b =>
                {
                    b.HasOne("MarioKart7Builder.Models.Body", "body")
                        .WithMany()
                        .HasForeignKey("bodyid");

                    b.HasOne("MarioKart7Builder.Models.Character", "character")
                        .WithMany()
                        .HasForeignKey("characterid");

                    b.HasOne("MarioKart7Builder.Models.Glider", "glider")
                        .WithMany()
                        .HasForeignKey("gliderid");

                    b.HasOne("MarioKart7Builder.Models.Tire", "tire")
                        .WithMany()
                        .HasForeignKey("tireid");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MarioKart7Builder.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MarioKart7Builder.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MarioKart7Builder.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
