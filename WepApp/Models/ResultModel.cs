using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepApp.Models
{
    public class ResultModel
    {

        public String id { get; set; }
        public String type { get; set; }
        public String url { get; set; }
        public String created_at { get; set; }
        public String location { get; set; }
        public String title { get; set; }
        public String description { get; set; }
        public String how_to_apply { get; set; }
        public String company_logo { get; set; }

    }
}