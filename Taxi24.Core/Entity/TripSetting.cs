using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Entity
{
    public class TripSetting : EntityBase
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string? Code { get; set; }
        public SettingsType SettingsType { get; set; }
    }


    public sealed class TripSettingMap : IEntityTypeConfiguration<TripSetting>
    {
        public void Configure(EntityTypeBuilder<TripSetting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Ignore(x => x.CreationDate);
            builder.Ignore(x => x.ModificationUser);
            builder.Ignore(x => x.CreationUser);
            builder.Ignore(x => x.ModificationDate);
            builder.Ignore(x => x.ModificationDate);

            builder.HasData(new TripSetting
            {
                Id = 1,
                Name = "kilometerPrice",
                Value = "5"
            },
            new TripSetting
            {
                Id = 2,
                Name = "WaitingPrice",
                Value = "5"
            },
            new TripSetting
            {
                Id = 3,
                Name = "PassangerCancellationPrice",
                Value = "5"
            },
            new TripSetting
            {
                Id = 4,
                Name = "DriverCancellationPrice",
                Value = "5"
            },
            new TripSetting
            {
                Id = 5,
                Name = "ApplicationPrice",
                Value = "5"
            },
            new TripSetting
            {
                Id = 6,
                Name = "SedanCarPriceForkilometer",
                Value = "1"
            },
            new TripSetting
            {
                Id = 7,
                Name = "FamilyCarPriceForkilometer",
                Value = "2"
            }
            );


        }
    }

}
