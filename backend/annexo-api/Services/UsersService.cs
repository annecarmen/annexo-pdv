using annexo_api.Models;

namespace annexo_api.Services;

public class UsersService { 

    public async Task<List<User>> GetUsersAsync()
    {
        
        var users = new List<User>();
        return users;
    }

    public async Task<User> CreateUserAsync(User user)
    {
        if(user.Email.Contains("@") != true)
        {
            throw new ArgumentException("Email inválido");
        }

        if(!user.Name.Contains(" "))
        {
            throw new ArgumentException("Nome inválido");
        }

        return user;
    }
}

