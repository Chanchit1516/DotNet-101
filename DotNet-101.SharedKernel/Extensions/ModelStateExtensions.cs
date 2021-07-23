using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet_101.SharedKernel.Extensions
{
    public static class ModelStateExtensions
    {
        public static string FirstError(this ModelStateDictionary modelState)
        {
            return modelState.Where(ms => ms.Value.Errors.Any()).Select(s => s.Value.Errors.FirstOrDefault().ErrorMessage).FirstOrDefault();
        }
    }
}
