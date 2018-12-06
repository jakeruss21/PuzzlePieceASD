using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class PhoneNumber
    {
        public int PhoneNumberID { get; set; }

        public int UserID { get; set; }

        public string PhoneNum { get; set; }
    }
}
