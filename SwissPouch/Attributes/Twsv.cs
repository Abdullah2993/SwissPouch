using System;

namespace SwissPouch.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Twsv : Attribute
    {
        public string Title { get; set; }
        public string FirstButtonLabel { get; set; }
        public string SecondButtonLabel { get; set; }
        public string Method { get; set; }
        public Twsv(string title, string firstButtonLabel,string secondButtonLabel,string method="GET")
        {
            Title = title;
            FirstButtonLabel = firstButtonLabel;
            SecondButtonLabel = secondButtonLabel;
            Method = method;
        }
    }
}