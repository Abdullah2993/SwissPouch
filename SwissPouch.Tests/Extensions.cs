using SwissPouch.Models;

namespace SwissPouch.Tests
{
    public static class Extensions
    {
        public static DataModel ToDataModel(this string data)
        {
            return new DataModel {Data = data};
        }
    }
}