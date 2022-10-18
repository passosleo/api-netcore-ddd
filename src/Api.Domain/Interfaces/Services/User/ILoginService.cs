using Api.Domain.Entities;
using Domain.Dtos;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<UserEntity> FindByLogin(LoginDTO login);
    }
}
