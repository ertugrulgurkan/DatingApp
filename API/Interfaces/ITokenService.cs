using API.Entities;

namespace API.Interfaces
{
    public interface TokenService
    {
        string CreateToken(AppUser user);
    }
}