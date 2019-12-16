using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiApplication.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указали ИИН")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Некорректный ИИН")]
        public string IIN { get; set; }

        //[RegularExpression(@"^\d+$", ErrorMessage = "Имя должен состоять только из букв")]
        [Required(ErrorMessage = "Не указали имя")]
        public string FirstName { get; set; }

        //[RegularExpression(@"^\d+$", ErrorMessage = "Фамилия должна состоять только из букв")]
        [Required(ErrorMessage = "Не указали фамилию")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Не указали дату рождения")]
        //[RegularExpression(@"^\d+$", ErrorMessage = "Введите дату рождения в формате ДД-ММ-ГГГГ")]
        public string BirthDate { get; set; }
    }
}