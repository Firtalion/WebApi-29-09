using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_29_09.Models;

namespace WebApi_29_09.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public HttpResponseMessage Post([FromBody] Authentification auth)
        {
            int valide = 0;
            string message = "Authentification échoué";
            if (auth.UserName == "test" && auth.PassWd == "azerty")
            {
                valide = 1;
                message = "Authentification réussie";
            }
            var data = new { valide, message };
            var JsonStr = JsonConvert.SerializeObject(data);
            var Content = new StringContent(JsonStr, System.Text.Encoding.UTF8, "application/json");
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = Content };
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
