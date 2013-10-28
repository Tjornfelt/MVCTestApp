using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCTestApp.Classes
{
    //Extending the RequiredAttribute to use a dictionary item.
    public class UmbracoRequiredAttribute : RequiredAttribute, IClientValidatable
    {
        //In the constructer, get the dictionary key.
        //
        public UmbracoRequiredAttribute(string dictionaryKey)
        {
            //Set the dictionary key as the error message, on the RequiredAttribute property. (the inherited class)
            this.ErrorMessage = dictionaryKey;
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
                ValidationType = "required"
            };
        }
    }
}