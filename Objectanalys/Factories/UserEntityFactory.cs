using Objectanalys.Models.Entities;

namespace Objectanalys.Factories;

public class UserEntityFactory
{     
    public static UserEntity Create()
    {
        return new UserEntity()
        {
            Id = Guid.NewGuid(),
            SecurityStamp = Guid.NewGuid().ToString()
        };
    }
}
