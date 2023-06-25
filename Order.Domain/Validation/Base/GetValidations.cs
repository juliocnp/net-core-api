using FluentValidation.Results;

namespace Order.Domain.Validation.Base
{
    public static class GetValidations
    {
        public static Response GetErrors(this ValidationResult result)
        {
            var response = new Response();

            if (result.IsValid is false)
            {
                foreach (var error in result.Errors)
                {
                    response.Report?.Add(new Report()
                    {
                        Code = error.PropertyName,
                        Message = error.ErrorMessage
                    });
                }

                return response;
            }

            return response;
        }
    }
}
