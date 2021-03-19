using Autodesk.Forge;
using BIMHub_NoDB_31.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BIMHub_NoDB_31.Controllers
{
    public class HomeController : Controller
    {
        private static dynamic PublicToken { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public Token gettoken()
        {
            Token returnobj = new Token();

            TwoLeggedApi oauth = new TwoLeggedApi();

            string grantType = "client_credentials";

            string FORGE_CLIENT_ID = "g0kwQcyAs8TpiFGe5OPq6dbIh20BaKhw";
            string FORGE_CLIENT_SECRET = "wsK6CJQcs4pEgopw";

            PublicToken = oauth.Authenticate(
              FORGE_CLIENT_ID,
              FORGE_CLIENT_SECRET,
              grantType,
              new Scope[] { Scope.DataRead, Scope.BucketRead, Scope.AccountRead, Scope.BucketUpdate, Scope.DataWrite });

            JObject jobj = PublicToken.ToJson();
            returnobj.access_token = jobj["access_token"].ToString();
            returnobj.expires_in = jobj["expires_in"].ToString();

            return returnobj;
        }
    }
}
