using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace WepApp.Models
{
    public class SearchModel
    {

        [Required(ErrorMessage ="You need to enter a location")]
        public string location { get; set; }
        
        
        [Required(ErrorMessage = "You need to enter a description")]
        public string description { get; set; }



    }
}