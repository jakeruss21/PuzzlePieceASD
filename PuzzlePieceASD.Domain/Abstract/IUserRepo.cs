using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PuzzlePieceASD.Domain.Abstract
{
    public interface IUserRepo
    {
        IEnumerable<User> Users { get; }
    }
}
