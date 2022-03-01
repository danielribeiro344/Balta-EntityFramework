using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoEntity.Models;

namespace ProjetoEntity.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

       // public DbSet<PostTag> PostTags { get; set; }

        //public DbSet<Role> Roles { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

       // public DbSet<UserRole> UserRoles { get; set; }

   
        protected override void OnConfiguring
            (DbContextOptionsBuilder options)

           
        {
            options.UseSqlServer("Server=DANIEL-PC;Database=Blog;Integrated Security=SSPI");
        }
        


    }
}
