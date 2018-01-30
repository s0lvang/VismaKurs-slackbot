using System.Collections.Generic;

namespace slack.Models
{
    public class SlackReply
    {
        public string Text { get; set; };
        public List<Attachment> Attachments { get; set; }; 
        
    }
}