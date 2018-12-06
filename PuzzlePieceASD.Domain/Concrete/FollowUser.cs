using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class FollowUser
    {
        [Key]
        public int FollowingUser { get; set; }

        public int UserBeingFollowed { get; set; }

    }
}
