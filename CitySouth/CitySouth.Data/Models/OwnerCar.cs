using System;
using System.Collections.Generic;

namespace CitySouth.Data.Models
{
    public partial class OwnerCar
    {
        public int CarId { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarNumber { get; set; }
        public Nullable<System.DateTime> ParkingExpireDate { get; set; }
        public string Remark { get; set; }
    }
}
