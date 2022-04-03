using LanchesMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LanchesMVC.Models
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        #region Users and Roles IDs
        #region Admin
        Guid IdRoleAdmin = Guid.NewGuid();
        Guid IdUseradmin = Guid.NewGuid();
        #endregion
        #region Member
        Guid IdRoleMember = Guid.NewGuid();
        Guid IdUserMember = Guid.NewGuid();
        #endregion
        #endregion

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        #region Seed Users and Roles
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedUsers(builder);
            SeedUsersRoles(builder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = IdRoleAdmin.ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },

                new IdentityRole()
                {
                    Id= IdRoleMember.ToString(),
                    Name = "Member",
                    NormalizedName = "MEMBER"
                }
            );
        }

        private void SeedUsers(ModelBuilder builder)
        {
            IdentityUser userAdmin = new IdentityUser()
            {
                Id = IdUseradmin.ToString(),
                UserName = "sysadmin",
                Email = "sysadmin@localhost.com",
                NormalizedUserName = "SYSADMIN",
                NormalizedEmail = "SYSADMIN@LOCALHOST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = "Admin123"
            };

            builder.Entity<IdentityUser>().HasData(userAdmin);

            IdentityUser userMember = new IdentityUser()
            {
                Id = IdUserMember.ToString(),
                UserName = "sysmember",
                Email = "sysmember@localhost.com",
                NormalizedUserName = "SYSMEMBER",
                NormalizedEmail = "SYSMEMBER@LOCALHOST.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = "Member123"
            };

            builder.Entity<IdentityUser>().HasData(userMember);
        }

        private void SeedUsersRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = IdRoleAdmin.ToString(),
                    UserId = IdUseradmin.ToString()
                },
                new IdentityUserRole<string>
                {
                    RoleId = IdRoleMember.ToString(),
                    UserId = IdUserMember.ToString()
                }
            ) ;
        }
        #endregion

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set;}
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidosDetalhes { get; set; }
    }
}
