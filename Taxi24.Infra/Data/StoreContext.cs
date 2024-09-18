using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Entity;

namespace Taxi24.Infra.Data
{
    public class StoreContext : DbContext
    {
        //public StoreContext()
        //{

        //}
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new DriverMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new PointMap());
            modelBuilder.ApplyConfiguration(new LocationMap());
            modelBuilder.ApplyConfiguration(new PromoCodeMap());
            modelBuilder.ApplyConfiguration(new PaymentMethodMap());
            modelBuilder.ApplyConfiguration(new OrderPaymentMethodMap());
            modelBuilder.ApplyConfiguration(new FaviroteMap());
            modelBuilder.ApplyConfiguration(new RiderMap());
            modelBuilder.ApplyConfiguration(new NotificationMap());
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new PhotosMap());
            modelBuilder.ApplyConfiguration(new SupportMap());
            modelBuilder.ApplyConfiguration(new CardsMap());
            modelBuilder.ApplyConfiguration(new PermissionMap());
            modelBuilder.ApplyConfiguration(new UserPermissionsMap());
            modelBuilder.ApplyConfiguration(new WalletMap());
            modelBuilder.ApplyConfiguration(new AccountMap());
            modelBuilder.ApplyConfiguration(new WalletActionsMap());
            modelBuilder.ApplyConfiguration(new TransactionMap());
            modelBuilder.ApplyConfiguration(new TripSettingMap());
            modelBuilder.ApplyConfiguration(new GroupMap());
            modelBuilder.ApplyConfiguration(new OrderTempMap());
            modelBuilder.ApplyConfiguration(new NotificationMessagesMap());
            modelBuilder.ApplyConfiguration(new LookupMap());
            modelBuilder.ApplyConfiguration(new LookupValuesMap());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connectionStr = "server=162.240.210.43; port=3306;  database=dev-taxi24; user=dev-taxi24; password=m_l1Rc384; Persist Security Info=False; Connect Timeout=300";
        //    //string connectionStr = "server=162.240.210.43; port=3306;  database=taxi24; user=taxi24; password=102010020010002000Abc0161820a; Persist Security Info=False; Connect Timeout=300";
        //    optionsBuilder.UseMySql(ServerVersion.AutoDetect(connectionStr));
        //}
    }
}
