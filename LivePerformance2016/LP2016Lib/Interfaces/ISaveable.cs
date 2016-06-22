using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016Lib.Interfaces
{
    /// <summary>
    /// Interface for classes that have to saved in a database.
    /// </summary>
    public interface ISaveable
    {
        /// <summary>
        /// The id of the class in the database.
        /// </summary>
        int Id { get; }
    }
}
