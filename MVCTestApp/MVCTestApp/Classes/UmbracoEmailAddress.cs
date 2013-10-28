using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using DataAnnotationsExtensions;
using System.Web.Mvc;

namespace MVCTestApp.Classes
{
    public class UmbracoEmailAddressAttribute : EmailAttribute, IClientValidatable
    {
        public UmbracoEmailAddressAttribute(string dictionaryKey)
        {

        }

        public override string FormatErrorMessage(string name)
        {
            return umbraco.library.GetDictionaryItem(name);
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, ControllerContext context)
        {
            // Kodus to "Chad" http://stackoverflow.com/a/9914117
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.ErrorMessage,
                ValidationType = "email"
            };
        }
    }
}