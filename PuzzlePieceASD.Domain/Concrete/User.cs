using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [Range(8, 50)]
        [Required(ErrorMessage = "Password must be at least 8 characters long, and no longer than 50 characters")]
        public string Password { get; set; }

        public int UserType { get; set; }

        public ICollection<UserType> UserTypes { get; set; }
    }
}

