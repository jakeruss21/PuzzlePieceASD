using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class Post
    {
        public int PostID { get; set; }

        public int UserID_FK { get; set; }

        public string Posting { get; set; }

        public Nullable<System.DateTime> PostingTime { get; set; }

    }
}
