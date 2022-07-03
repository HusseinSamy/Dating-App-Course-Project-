using Dating_App.Entities;

namespace Dating_App.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(AppUser user);
    }
}
