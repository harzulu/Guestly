﻿// <auto-generated />
using System;
using Guestly.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Guestly.Migrations
{
    [DbContext(typeof(GuestlyContext))]
    [Migration("20210125195135_Fourth")]
    partial class Fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Guestly.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Guestly.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("LifetimeNights");

                    b.Property<float>("LifetimeRevenue");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");

                    b.HasData(
                        new
                        {
                            GuestId = 1,
                            Email = "jd@email.com",
                            FirstName = "Jack",
                            LastName = "Daniel",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1223334444"
                        },
                        new
                        {
                            GuestId = 2,
                            Email = "thisisdrew@email.com",
                            FirstName = "Drew",
                            LastName = "Mason",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5673451231"
                        },
                        new
                        {
                            GuestId = 3,
                            Email = "matthewpatel@email.com",
                            FirstName = "Matthew",
                            LastName = "Patel",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "192837465"
                        },
                        new
                        {
                            GuestId = 4,
                            Email = "sethdoray@email.com",
                            FirstName = "Seth",
                            LastName = "Doray",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5033505003"
                        },
                        new
                        {
                            GuestId = 5,
                            Email = "doublerich@email.com",
                            FirstName = "Richard",
                            LastName = "Richardson",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9717717771"
                        },
                        new
                        {
                            GuestId = 6,
                            Email = "cal3b3dwards@email.com",
                            FirstName = "Caleb",
                            LastName = "Edwards",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2736498710"
                        },
                        new
                        {
                            GuestId = 7,
                            Email = "volleyballrox@email.com",
                            FirstName = "Shoyo",
                            LastName = "Hinita",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1133224433"
                        },
                        new
                        {
                            GuestId = 8,
                            Email = "rileykeys@email.com",
                            FirstName = "Riley",
                            LastName = "Keys",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4252075079"
                        },
                        new
                        {
                            GuestId = 9,
                            Email = "heyyouparkit@email.com",
                            FirstName = "Parker",
                            LastName = "Wallenburger",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5555599999"
                        },
                        new
                        {
                            GuestId = 10,
                            Email = "mydognigel@email.com",
                            FirstName = "Nigel",
                            LastName = "Dogo",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "3333333333"
                        },
                        new
                        {
                            GuestId = 11,
                            Email = "rickiede@email.com",
                            FirstName = "Rick",
                            LastName = "Ellis",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4155558956"
                        },
                        new
                        {
                            GuestId = 12,
                            Email = "acathome@email.com",
                            FirstName = "Alex",
                            LastName = "Calder",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5065558989"
                        },
                        new
                        {
                            GuestId = 13,
                            Email = "elbell@email.com",
                            FirstName = "Erica",
                            LastName = "Bell",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9715558562"
                        },
                        new
                        {
                            GuestId = 14,
                            Email = "denicolab@email.com",
                            FirstName = "Bobby",
                            LastName = "DeNicola",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "7075559846"
                        },
                        new
                        {
                            GuestId = 15,
                            Email = "emmunoz@email.com",
                            FirstName = "Ellie",
                            LastName = "Munoz",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5035556231"
                        },
                        new
                        {
                            GuestId = 16,
                            Email = "jmcteller@email.com",
                            FirstName = "Joshua",
                            LastName = "McTeller",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4155558894"
                        },
                        new
                        {
                            GuestId = 17,
                            Email = "nnatell@email.com",
                            FirstName = "Natalie",
                            LastName = "Lass",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5415558896"
                        },
                        new
                        {
                            GuestId = 18,
                            Email = "tridoublep@email.com",
                            FirstName = "Tripp",
                            LastName = "Ford",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5035552483"
                        },
                        new
                        {
                            GuestId = 19,
                            Email = "wilford@email.com",
                            FirstName = "Willie",
                            LastName = "Ford",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4155556472"
                        },
                        new
                        {
                            GuestId = 20,
                            Email = "katwoz@email.com",
                            FirstName = "Kaitlin",
                            LastName = "Wozniak",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5035558258"
                        },
                        new
                        {
                            GuestId = 21,
                            Email = "madalynl11@email.com",
                            FirstName = "Madalyn",
                            LastName = "Lathem",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6514553861"
                        },
                        new
                        {
                            GuestId = 22,
                            Email = "sean.mercado04@email.com",
                            FirstName = "Sean",
                            LastName = "Mercado",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5018988936"
                        },
                        new
                        {
                            GuestId = 23,
                            Email = "viktoriaaksnes@email.com",
                            FirstName = "Viktoria",
                            LastName = "Nielsen",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "7843247148"
                        },
                        new
                        {
                            GuestId = 24,
                            Email = "now@email.com",
                            FirstName = "Nao",
                            LastName = "Oka",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "3193198947"
                        },
                        new
                        {
                            GuestId = 25,
                            Email = "bernie@mittens.com",
                            FirstName = "Bernie",
                            LastName = "Hancock",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2778649180"
                        },
                        new
                        {
                            GuestId = 26,
                            Email = "pratte16@email.com",
                            FirstName = "Eleanor",
                            LastName = "Pratte",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4529407334"
                        },
                        new
                        {
                            GuestId = 27,
                            Email = "aurorabergen@email.com",
                            FirstName = "Aurora",
                            LastName = "Berg",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1338214188"
                        },
                        new
                        {
                            GuestId = 28,
                            Email = "mr.underhill@email.com",
                            FirstName = "Frodo",
                            LastName = "Baggins",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5385970949"
                        },
                        new
                        {
                            GuestId = 29,
                            Email = "takanoart@email.com",
                            FirstName = "Aya",
                            LastName = "Takano",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2969397018"
                        },
                        new
                        {
                            GuestId = 30,
                            Email = "deckard.rick@email.com",
                            FirstName = "Rick",
                            LastName = "Deckard",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6192533993"
                        },
                        new
                        {
                            GuestId = 31,
                            Email = "happy_golfmore@email.com",
                            FirstName = "Happy",
                            LastName = "Gilmore",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1234578900"
                        },
                        new
                        {
                            GuestId = 32,
                            Email = "joycesummers@email.com",
                            FirstName = "Joyce",
                            LastName = "Summers",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1987899876"
                        },
                        new
                        {
                            GuestId = 33,
                            Email = "KHarm123@email.com",
                            FirstName = "Harmony",
                            LastName = "Kendall",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1465768945"
                        },
                        new
                        {
                            GuestId = 34,
                            Email = "JennyCal@email.com",
                            FirstName = "Jenny",
                            LastName = "Calendar",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2343546754"
                        },
                        new
                        {
                            GuestId = 35,
                            Email = "anointed1_66@email.com",
                            FirstName = "Annointed",
                            LastName = "One",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6894562341"
                        },
                        new
                        {
                            GuestId = 36,
                            Email = "H.Sums@email.com",
                            FirstName = "Hank",
                            LastName = "Summers",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1029384234"
                        },
                        new
                        {
                            GuestId = 37,
                            Email = "jessekmcjay@email.com",
                            FirstName = "Jesse",
                            LastName = "McNally",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4675823123"
                        },
                        new
                        {
                            GuestId = 38,
                            Email = "JonLev@email.com",
                            FirstName = "Jonathan",
                            LastName = "Levinson",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9858673452"
                        },
                        new
                        {
                            GuestId = 39,
                            Email = "eRayne@email.com",
                            FirstName = "Ethan",
                            LastName = "Rayne",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2384655432"
                        },
                        new
                        {
                            GuestId = 40,
                            Email = "gottahavefaith@email.com",
                            FirstName = "Faith",
                            LastName = "Lehane",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2349853456"
                        },
                        new
                        {
                            GuestId = 41,
                            Email = "notTaratino@email.com",
                            FirstName = "Quentin",
                            LastName = "Travers",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "3458768676"
                        },
                        new
                        {
                            GuestId = 42,
                            Email = "scott!@email.com",
                            FirstName = "Scott",
                            LastName = "Hope",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5436667534"
                        },
                        new
                        {
                            GuestId = 43,
                            Email = "asYouWish@email.com",
                            FirstName = "Wesley",
                            LastName = "Pryce",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2345674564"
                        },
                        new
                        {
                            GuestId = 44,
                            Email = "PromQueen@email.com",
                            FirstName = "Cordelia",
                            LastName = "Chase",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "5543234321"
                        },
                        new
                        {
                            GuestId = 45,
                            Email = "OnlyBuffyWillJudge@email.com",
                            FirstName = "Buffy",
                            LastName = "Summers",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "8778887634"
                        },
                        new
                        {
                            GuestId = 46,
                            Email = "Bookguy@email.com",
                            FirstName = "Rupert",
                            LastName = "Giles",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4756566879"
                        },
                        new
                        {
                            GuestId = 47,
                            Email = "witchStuff@email.com",
                            FirstName = "Willow",
                            LastName = "Rosenberg",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "7998884475"
                        },
                        new
                        {
                            GuestId = 48,
                            Email = "jokesDotCom@email.com",
                            FirstName = "Xander",
                            LastName = "Harris",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "3334958679"
                        },
                        new
                        {
                            GuestId = 49,
                            Email = "BadBois@email.com",
                            FirstName = "William",
                            LastName = "Pratt",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4445556634"
                        },
                        new
                        {
                            GuestId = 50,
                            Email = "ImaMouse@email.com",
                            FirstName = "Amy",
                            LastName = "Madison",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2873345543"
                        },
                        new
                        {
                            GuestId = 51,
                            Email = "TwoNewtons@email.com",
                            FirstName = "Cassie",
                            LastName = "Newton",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9987896786"
                        },
                        new
                        {
                            GuestId = 52,
                            Email = "Alternate@email.com",
                            FirstName = "Chao",
                            LastName = "Ahn",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6675844776"
                        },
                        new
                        {
                            GuestId = 53,
                            Email = "SeattleResident@email.com",
                            FirstName = "Count",
                            LastName = "Dracula",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9980987867"
                        },
                        new
                        {
                            GuestId = 54,
                            Email = "militarystuff@email.com",
                            FirstName = "Forrest",
                            LastName = "Gates",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "8009978865"
                        },
                        new
                        {
                            GuestId = 55,
                            Email = "Indiacohen@email.com",
                            FirstName = "India",
                            LastName = "Cohen",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "9078788986"
                        },
                        new
                        {
                            GuestId = 56,
                            Email = "janicePenshaw@email.com",
                            FirstName = "Janice",
                            LastName = "Penshaw",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6678745632"
                        },
                        new
                        {
                            GuestId = 57,
                            Email = "KathyNewman@email.com",
                            FirstName = "Kathy",
                            LastName = "Newman",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "1122212345"
                        },
                        new
                        {
                            GuestId = 58,
                            Email = "KendraYoung@email.com",
                            FirstName = "Kendra",
                            LastName = "Young",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "4645534233"
                        },
                        new
                        {
                            GuestId = 59,
                            Email = "TheDevil@email.com",
                            FirstName = "Satan",
                            LastName = "Lucifer",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "6666666666"
                        },
                        new
                        {
                            GuestId = 60,
                            Email = "TheJenny@email.com",
                            FirstName = "Jenny",
                            LastName = "Jenny",
                            LifetimeNights = 0,
                            LifetimeRevenue = 0f,
                            PhoneNumber = "2018675309"
                        });
                });

            modelBuilder.Entity("Guestly.Models.GuestRoom", b =>
                {
                    b.Property<int>("GuestRoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GuestId");

                    b.Property<int>("Nights");

                    b.Property<int>("RoomId");

                    b.HasKey("GuestRoomId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("GuestRoom");

                    b.HasData(
                        new
                        {
                            GuestRoomId = 1,
                            GuestId = 1,
                            Nights = 2,
                            RoomId = 1
                        },
                        new
                        {
                            GuestRoomId = 2,
                            GuestId = 2,
                            Nights = 1,
                            RoomId = 2
                        },
                        new
                        {
                            GuestRoomId = 3,
                            GuestId = 5,
                            Nights = 4,
                            RoomId = 3
                        },
                        new
                        {
                            GuestRoomId = 4,
                            GuestId = 10,
                            Nights = 5,
                            RoomId = 4
                        },
                        new
                        {
                            GuestRoomId = 5,
                            GuestId = 1,
                            Nights = 3,
                            RoomId = 4
                        });
                });

            modelBuilder.Entity("Guestly.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Price");

                    b.Property<string>("RoomNumber");

                    b.Property<string>("RoomType");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomId = 1,
                            Price = 125f,
                            RoomNumber = "104",
                            RoomType = "King"
                        },
                        new
                        {
                            RoomId = 2,
                            Price = 110f,
                            RoomNumber = "345",
                            RoomType = "Queen"
                        },
                        new
                        {
                            RoomId = 3,
                            Price = 85f,
                            RoomNumber = "210",
                            RoomType = "Baby"
                        },
                        new
                        {
                            RoomId = 4,
                            Price = 150f,
                            RoomNumber = "111",
                            RoomType = "Suite"
                        },
                        new
                        {
                            RoomId = 5,
                            Price = 95f,
                            RoomNumber = "206",
                            RoomType = "Full"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Guestly.Models.GuestRoom", b =>
                {
                    b.HasOne("Guestly.Models.Guest", "Guest")
                        .WithMany("Rooms")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Guestly.Models.Room", "Room")
                        .WithMany("Guests")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Guestly.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Guestly.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Guestly.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Guestly.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
