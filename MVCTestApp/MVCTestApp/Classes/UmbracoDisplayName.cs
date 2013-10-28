using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVCTestApp.Classes
{
    //Override the DisplayName property of the DisplayNameAttribute

    public class UmbracoDisplayNameAttribute : DisplayNameAttribute
    {
        //The DisplayNameAttribute has a constructor which takes a string. When we extend it, we have to provide a value to pass into the constructor.
        //We use the umbraco dictionary key.
        public UmbracoDisplayNameAttribute(string dictionaryKey) : base(dictionaryKey)
        {

        }

        //Then we override the method which generates the DisplayName, by fetching the umbraco dictionary item.
        public override string DisplayName
        {
            get
            {
                return umbraco.library.GetDictionaryItem(base.DisplayName);
            }
        }
    }
}