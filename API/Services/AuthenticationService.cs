using Common.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AuthenticationService
    {
        public User LoggedUser { get; private set; }
        public void AuthenticateUser(string username, string password)
        {
            FootballersRepository footballersRepository = new FootballersRepository();
            LoggedUser = footballersRepository.GetAll().Where(item => item.Username == username && item.Password == password).FirstOrDefault();

            if (LoggedUser != null)
            {
                return;
            }

            RefereesRepository refereesRepository = new RefereesRepository();
            LoggedUser = refereesRepository.GetAll().Where(item => item.Username == username && item.Password == password).FirstOrDefault();
        }
    }
}
