using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwissPouch.Models
{
    public class DataModel
    {
        public string Data { get; set; }

        //public static explicit operator DataModel(string data)
        //{
        //    return new DataModel{ Data = data };
        //}

        //public static explicit operator string(DataModel model)
        //{
        //    return model.Data;
        //}
    }
}