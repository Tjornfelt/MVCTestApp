using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;
using MVCTestApp.Classes;

namespace MVCTestApp.Models
{
    
    public class TestForm
    {
        [Display(Name="String label")]
        [Required(ErrorMessage="This string is required!")]
        public string String { get; set; }

        [UmbracoDisplayName("FormItem")]
        [UmbracoRequired("NewDictionaryItem")]
        //[Email(ErrorMessage="invalid address")]
        [UmbracoEmailAddress("FormItem")]
        public string Email { get; set; }

    }
}