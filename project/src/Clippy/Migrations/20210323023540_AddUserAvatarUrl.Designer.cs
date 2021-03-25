﻿// <auto-generated />
using System;
using Clippy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clippy.Migrations
{
    [DbContext(typeof(ClippyContext))]
    [Migration("20210323023540_AddUserAvatarUrl")]
    partial class AddUserAvatarUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("Clippy.Entities.Bookmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookmarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 3, 2, 18, 21, 8, 0, DateTimeKind.Utc),
                            ResourceId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 3, 3, 17, 38, 42, 0, DateTimeKind.Utc),
                            ResourceId = 3,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 3, 3, 23, 59, 0, 0, DateTimeKind.Utc),
                            ResourceId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2021, 3, 4, 5, 12, 58, 0, DateTimeKind.Utc),
                            ResourceId = 5,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2021, 3, 10, 9, 45, 32, 0, DateTimeKind.Utc),
                            ResourceId = 6,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Clippy.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Metadata")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.HasIndex("Location")
                        .IsUnique();

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 3, 2, 14, 8, 6, 0, DateTimeKind.Utc),
                            Location = "https://www.nationalgeographic.com",
                            Metadata = "{\"Title\":\"National Geographic\",\"MediaType\":\"text/html\",\"ImageURL\":\"natgeo.jpg\",\"Description\":\"Explore the world\\u0027s beauty.\"}"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2021, 3, 2, 18, 21, 8, 0, DateTimeKind.Utc),
                            Location = "https://www.nps.gov/yell/index.htm",
                            Metadata = "{\"Title\":\"Yellowstone National Park\",\"MediaType\":\"text/html\",\"ImageURL\":\"yellowstone.jpg\",\"Description\":\"Escape to a winter wonderland.\"}"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2021, 3, 3, 17, 38, 42, 0, DateTimeKind.Utc),
                            Location = "https://www.foodnetwork.com",
                            Metadata = "{\"Title\":\"Food Network\",\"MediaType\":\"text/html\",\"ImageURL\":\"foodnetwork.jpg\",\"Description\":\"Entice your taste buds.\"}"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2021, 3, 3, 23, 59, 0, 0, DateTimeKind.Utc),
                            Location = "https://www.loveandlemons.com",
                            Metadata = "{\"Title\":\"Love and Lemons\",\"MediaType\":\"text/html\",\"ImageURL\":\"lovelemons.jpg\",\"Description\":\"Detoxify yourself each day.\"}"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2021, 3, 4, 5, 12, 58, 0, DateTimeKind.Utc),
                            Location = "https://appalachiantrail.org",
                            Metadata = "{\"Title\":\"Appalachian Trail Conservancy\",\"MediaType\":\"text/html\",\"ImageURL\":\"appalachiantrail.jpg\",\"Description\":\"Escape the city lights.\"}"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2021, 3, 10, 9, 45, 32, 0, DateTimeKind.Utc),
                            Location = "https://www.spacex.com",
                            Metadata = "{\"Title\":\"SpaceX\",\"MediaType\":\"text/html\",\"ImageURL\":\"spacex.jpg\",\"Description\":\"Experience space travel.\"}"
                        });
                });

            modelBuilder.Entity("Clippy.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Clippy.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookmarkId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookmarkId");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookmarkId = 1,
                            TagName = "favorite"
                        },
                        new
                        {
                            Id = 2,
                            BookmarkId = 2,
                            TagName = "favorite"
                        },
                        new
                        {
                            Id = 3,
                            BookmarkId = 3,
                            TagName = "favorite"
                        },
                        new
                        {
                            Id = 4,
                            BookmarkId = 4,
                            TagName = "favorite"
                        },
                        new
                        {
                            Id = 5,
                            BookmarkId = 5,
                            TagName = "favorite"
                        });
                });

            modelBuilder.Entity("Clippy.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bio")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("GithubId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2021, 3, 1, 20, 32, 2, 0, DateTimeKind.Utc),
                            Name = "Clippy5 Team",
                            Username = "Clippy5"
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<int>("FollowingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubscriptionsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("FollowingId", "SubscriptionsId");

                    b.HasIndex("SubscriptionsId");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("Clippy.Entities.Bookmark", b =>
                {
                    b.HasOne("Clippy.Entities.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clippy.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Clippy.Entities.Tag", b =>
                {
                    b.HasOne("Clippy.Entities.Bookmark", null)
                        .WithMany("Tags")
                        .HasForeignKey("BookmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Clippy.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clippy.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("Clippy.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clippy.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("SubscriptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clippy.Entities.Bookmark", b =>
                {
                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}