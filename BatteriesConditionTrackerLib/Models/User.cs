using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models;

namespace BatteriesConditionTrackerLib
{
    public class User
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество пользователя
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Должность пользователя
        /// </summary>
        public Position Position { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Хэш пароля пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Номер телефона пользователя
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Адрес электронной почты пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Администраторские права пользователя 
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// Руководитель пользователя
        /// </summary>
        public User Supervisor { get; set; }
    }
}
