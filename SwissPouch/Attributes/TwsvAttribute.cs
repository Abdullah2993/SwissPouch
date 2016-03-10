using System;

namespace SwissPouch.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TwsvAttribute : Attribute
    {
        public string Title { get; set; }
        public string FirstButtonLabel { get; set; }
        public string SecondButtonLabel { get; set; }
        public string PlaceHolder { get; set; }

        public TwsvAttribute(string title, string firstButtonLabel,string secondButtonLabel, string placeHolder = "Enter the text here...")
        {
            Title = title;
            FirstButtonLabel = firstButtonLabel;
            SecondButtonLabel = secondButtonLabel;
            PlaceHolder = placeHolder;
        }
    }
}