using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BatteriesConditionTrackerLib.Models.Interfaces;

namespace BatteriesConditionTrackerLib.Models
{
    public class User : IHaveId
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
        /// Номер телефона пользователя
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Адрес электронной почты пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Должность пользователя
        /// </summary>
        public Position? Position { get; set; }
        /// <summary>
        /// Хэш пароля пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Администраторские права пользователя 
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// ФИО пользователя
        /// </summary>
        public string FullName { get { return $"{Surname} {Name} {Patronymic}"; } }

        public static readonly Func<string[], User> ModelCreation = columns => new User(columns);
        public static readonly Func<User, string> ModelToCSV = user => $"{user.Id},{user.Name},{user.Surname},{user.Patronymic}," +
            $"{user.Password},{user.PhoneNumber},{user.Email},{(user.Position == null? "" : user.Position.Id)},{user.IsAdmin}";

        public User() { } 

        public User(string name, string surname, string patronymic, string password, string phoneNumber, string email, Position position, bool isAdmin) 
        {
            Name = name; 
            Surname = surname;
            Patronymic = patronymic; 
            Password = password;
            PhoneNumber = phoneNumber;
            Email = email;
            Position = position;
            IsAdmin = isAdmin;
        }

        public User(string[] columns)
        {
            Id = int.Parse(columns[0]);
            Name = columns[1];  
            Surname = columns[2];
            Patronymic = columns[3];
            Password = columns[4];
            PhoneNumber = columns[5];
            Email = columns[6];
            Position = string.IsNullOrEmpty(columns[7])? null : GlobalConfig.Connection.GetPosition_ById(int.Parse(columns[7]));
            IsAdmin = bool.Parse(columns[8]);   
        }

        public override string ToString()
        {
            return FullName; 
        }
    }
}
