using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class User
    {
        public int UserID { get; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Range(8, 50)]
        [Required(ErrorMessage = "Password must be at least 8 characters long, and no longer than 50 characters")]
        public string Password { get; set; }

        [StringLength(20)]
        public string UserType { get; set; }

        public int UserBio { get; set; }

    }
}

