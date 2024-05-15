using mytodolist.Data.DTO;
using mytodolist.Data.VO;

namespace mytodolist.Business
{
    public interface ILoginBusiness
    {
        TokenDTO ValidateCredentials(UserDTO user);

        TokenDTO ValidateCredentials(TokenDTO token);

        bool RevokeToken(string username);
    }
}
