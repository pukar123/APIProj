using HiredFirst.Domain.DTO;
using HiredFirstInfrastructure.Repositories;
using HiredFirststInfrastructure.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiredFirst.Domain.Services.Implementations
{
    public class UserService:IUserService
    {
        IBaseRepository<AppUser> _userRepo;

        public UserService(IBaseRepository<AppUser> userRepo)
        {
            _userRepo = userRepo;
        }

        public List<UserDTO> GetAllUsers()
        {
            var result =new List<UserDTO>();
            var dbresult = _userRepo.GetAll().ToList();
            MapDBEntityToDTO(dbresult, result);
            return result;

        }

        private void MapDBEntityToDTO(List<AppUser> dbEntities, List<UserDTO> dtos)
        {
            foreach(var data in dbEntities)
            {
                UserDTO result= new UserDTO();
                result.FirstName= data.FirstName;
                result.LastName= data.LastName;
                result.Email= data.Email;
                dtos.Add(result);

            }
           
        }
    }
}
