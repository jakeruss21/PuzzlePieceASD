using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PuzzlePieceASD.Domain.Concrete
{
    public class FollowUser
    {
        [Key]
        public int FollowID { get; set; }

        public int FollowingUser { get; set; }

        public int UserBeingFollowed { get; set; }

    }
}
