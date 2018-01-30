using Microsoft.AspNetCore.Mvc;
using slack.Models;

namespace slack.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SlackController : Controller
    {
        public string Get(SlackPostModel slack){

            var reply = new SlackReply();
            reply.Text = "hei hei!"
            var att = new Attachment();
            att.text = "wat da!"

            
            
        }
        
    }
}