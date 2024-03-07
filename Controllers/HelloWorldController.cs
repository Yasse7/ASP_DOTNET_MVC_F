using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace First_MVC_APP.Controllers
{
    [Route("HelloWorldController")]
    public class HelloWorldController : Controller
    {
        [HttpGet("default")]
        public string  Index()
        {
            return "this my default controller!!..";
        }
        [HttpGet("addition")]
        public string addition(float n1 , float n2)
        {
            return HtmlEncoder.Default.Encode($"the addition is {n1+n2}") ;
        }
    }
}
