using Microsoft.AspNetCore.Identity;

namespace Product_Demo.Models
{
    public class CustomerIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = "Paralo En Az 6 Karakter Olmalıdır"
            };          
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola En Az 1 Büyük Harf İçermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower ()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola En Az 1 Küçük Harf İçermelidir"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola En Az 1 AlfaNümerik Karakter İçermelidir"
            };
        }
    }
}
