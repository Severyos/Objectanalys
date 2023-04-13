using Objectanalys.Models.DTOs;

namespace Objectanalys.Factories;

public class UserResponseFactory
{
    public static UserResponse Create()
    {
        return new UserResponse();
    }
}
