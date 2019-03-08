using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.DataAccess.Helpers
{
    public enum IsolationLevel
    {

        Unspecified = -1,

        Chaos = 16,

        ReadUncommitted = 256,

        ReadCommitted = 4096,

        RepeatableRead = 65536,

        Serializable = 1048576,

        Snapshot = 16777216
    }
}
