using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PuzzlePieceASD.Domain.Concrete;

namespace PuzzlePieceASD.Domain.Abstract
{
    public interface IUserRepo
    {
        IEnumerable<UserType> UserTypes { get; }
    }
}
