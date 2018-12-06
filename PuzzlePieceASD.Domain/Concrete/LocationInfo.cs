using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class LocationInfo
    {
        [Key]
        public int LocationInfoID { get; set; }
        public int UserID { get; set; }

        public string StreetAddress1 { get; set; }

        public string StreetAddress2 { get; set; }

        public string StreetAddress3 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(25)]
        public string StateID { get; set; }

        [Range(5, 9)]
        public Nullable<int> Zipcode { get; set; }

    }
}
