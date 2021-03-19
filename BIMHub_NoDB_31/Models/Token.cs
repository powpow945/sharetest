using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIMHub_NoDB_31.Models
{
    public class Token
    {
        public string id { get; set; }
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }
}
