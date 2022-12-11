using FluentValidation;
using FluentValidation.Results;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceModel
{
    public static class GenericValidator
    {
        /// <summary>
        /// Generic validator that performs validation for a request object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="validationObject"></param>
        /// <param name="validator"></param>
        /// <returns></returns>
        public static async Task<(Boolean, ValidationResult)> ValidateRequest<T> (T validationObject, AbstractValidator<T> validator) where T : IReturn
        {
            ValidationResult result = await validator.ValidateAsync(validationObject);
            if (result.Errors.Any())
            {
                Console.Error.WriteLine($"Request has the following errors: \n{result}");
                return (true, result);
            }
            return (false, null);
        }
    }
}
