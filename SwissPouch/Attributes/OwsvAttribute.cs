using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissPouch.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OwsvAttribute:Attribute
    {
        public string Title { get; set; }
        public string ButtonLabel { get; set; }

        public OwsvAttribute(string title,string buttonLabel)
        {
            Title = title;
            ButtonLabel = buttonLabel;
        }      
    }
}