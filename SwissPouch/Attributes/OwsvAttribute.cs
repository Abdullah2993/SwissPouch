using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SwissPouch.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class OwsvAttribute:Attribute
    {
        public string Title { get; set; }
        public string ButtonLabel { get; set; }
        public string PlaceHolder { get; set; }

        public OwsvAttribute(string title,string buttonLabel,string placeHolder= "Enter the text here...")
        {
            Title = title;
            ButtonLabel = buttonLabel;
            PlaceHolder = placeHolder;
        }      
    }
}