using ClimaticService.Context;
using ClimaticService.Context.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaticService
{
    /// <summary>
    /// Работа с пользователем для разграничения по ролям
    /// </summary>
    public static class WorkToUser
    {
        private static User user;
        public static User User
        { 
            get 
            { 
                if(user == null)
                {
                    user = new User()
                    {
                        FullName = "Неавторизованный пользователь",
                        RoleId = 1,
                    };
                }
                return user; 
            }
            set { user = value; }
        }
    }
}
