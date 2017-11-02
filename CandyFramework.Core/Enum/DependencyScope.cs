using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Core.Enum
{
    /// <summary>
    /// Life time of a dependency
    /// </summary>
    public enum DependencyScope
    {
        /// <summary>
        /// Indicates that a dependency implementation will be created each time it is resolved
        /// </summary>
        Transient,

        /// <summary>
        /// Indicates that a dependency implementation will be created only one time when it is resolved in the same thread
        /// </summary>
        PerThread,

        /// <summary>
        /// Indicates that a dependency implementation will be created only one time when it is resolved in the same web request lifecycle
        /// </summary>
        PerWebRequest,

        /// <summary>
        /// Indicates that a dependency implementation will be created only one time for the application
        /// </summary>
        Singleton
    }
}
