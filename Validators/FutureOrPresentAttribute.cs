using System.ComponentModel.DataAnnotations;

namespace TwTodos.Validators;

public class FutureOrPresentAttribute : ValidationAttribute
{
    public FutureOrPresentAttribute()
    {
        ErrorMessage = "{0} deve ser no presente ou no futuro";
    }

    public override bool IsValid(object? value)
    {
        if (value is null)
        {
            return true;
        }

        var date = (DateOnly)value;
        return date >= DateOnly.FromDateTime(DateTime.Now);
        
    }
}
