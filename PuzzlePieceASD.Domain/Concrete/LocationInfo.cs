using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class LocationInfo
    {
        public int InfoID { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [Range(5, 9)]
        public Nullable<int> Zipcode { get; set; }

        public string UserEmail { get; set; }

        public string PhoneNumber { get; set; }
    }
}
