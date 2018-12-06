using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    class UserType
    {
        public int UserTypeID { get; set; }

        [Display (Name = "User Type")]
        public string TypeOfUser { get; set; }
    }
}
