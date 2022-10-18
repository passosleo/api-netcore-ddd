using Api.Domain.Entities;
using Domain.Dtos;
using Domain.Interfaces.Services.User;
using Domain.Repository;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserEntity> FindByLogin(LoginDTO login)
        {
            if (login != null && !string.IsNullOrWhiteSpace(login.Email))
            {
                return await _repository.FindByLogin(login.Email);
            }
            else
            {
                return null;
            }
        }
    }
}
