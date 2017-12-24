using CandyFramework.Core.Interface.Entity;
using System;

namespace CandyFramework.Entity.Interface.Base
{
    public interface IUser : IKeyEntity, IState
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        DateTime Birtdate { get; set; }
        string UserName { get; set; }
        int UserGroupId { get; set; }
    }
}
