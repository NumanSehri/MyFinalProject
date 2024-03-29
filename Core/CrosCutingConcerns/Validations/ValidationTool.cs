﻿using FluentValidation;

namespace Core.CrosCutingConcerns.Validations
{
    public  static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        { //Generic yapıldı
            var context = new ValidationContext<object>(entity);         
            var result =validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors); //hata fırlatma

            }
        }
    }
}
