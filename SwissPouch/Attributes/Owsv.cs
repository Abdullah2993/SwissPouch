using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissPouch.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Owsv:Attribute
    {
        public string Title { get; set; }
        public string ButtonLabel { get; set; }
        public string Link { get; set; }
        public string Method { get; set; }

        public Owsv(string title,string buttonLabel,string link,string method="GET")
        {
            Title = title;
            ButtonLabel = buttonLabel;
            Link = link;
            Method = method;
        }      
    }
}