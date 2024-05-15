using mytodolist.Data.DTO;


namespace mytodolist.Repository.User
{
    public interface IUserRepository
    {
        Model.User ValidateCredentials(UserDTO userDTO);

        Model.User ValidateCredentials(string username);

        bool RevokeToken(string username);

        Model.User RefreshUserInfo(Model.User user);
    }
}
