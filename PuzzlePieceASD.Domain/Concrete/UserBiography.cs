using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class UserBiography
    {
        [Key]
        public int BioID { get; set; }

        public int UserID { get; set; }

        public string BioInfo { get; set; }
    }
}
