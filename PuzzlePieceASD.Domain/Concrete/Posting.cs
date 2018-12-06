using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class Posting
    {
        public int PostID { get; set; }

        public int UserID { get; set; }

        public string Post { get; set; }

        public System.DateTime PostingTime { get; set; }
    }
}
