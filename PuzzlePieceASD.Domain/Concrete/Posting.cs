using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class Posting
    {
        [Key]
        public int PostID { get; set; }

        public int UserID { get; set; }

        public string Post { get; set; }

        public System.DateTime PostingTime { get; set; }
    }
}
