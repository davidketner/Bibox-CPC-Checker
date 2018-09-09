using Bibox.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Bibox
{
    public class Command
    {
        public const string api = "https://api.bibox.com/";
        public static Depth GetAsksAndBids(Pair pair, int size)
        {
            var url = api + "v1/mdata?cmd=depth&pair=" + pair.First.Symbol + "_" + pair.Second.Symbol + "&size=" + size;
            WebClient wc = new WebClient();
            Depth r = new JavaScriptSerializer().Deserialize<Depth>(wc.DownloadString(url));
            return r;
        }
    }
}
