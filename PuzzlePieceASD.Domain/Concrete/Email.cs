using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    class Email
    {
        public int EmailID { get; set; }

        public int UserID { get; set; }

        public string EmailAddress { get; set; }
    }
}
