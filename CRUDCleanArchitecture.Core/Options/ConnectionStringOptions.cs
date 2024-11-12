using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCleanArchitecture.Core.Options
{
    public class ConnectionStringOptions
    {
        public const string sectionName = "ConnectionStrings";
        public string DefaultConnection { get; set; } = null!;
        public string CoindeskConnection { get; set; } = null!;
    }
}
