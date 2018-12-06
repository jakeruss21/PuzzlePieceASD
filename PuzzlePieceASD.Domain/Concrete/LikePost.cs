using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class LikePost
    {
        [Key]
        public int UserID { get; set; }

        public int PostID { get; set; }
    }
}
