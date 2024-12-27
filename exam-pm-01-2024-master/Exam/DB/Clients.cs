using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DB
{
    internal class Clients
    {
        [System.ComponentModel.DisplayName("ID_Clients")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Имя")]
        public string firstName { get; set; } = String.Empty;
        [System.ComponentModel.DisplayName("Отчество")]
        public string lastName { get; set; } = string.Empty;
        
        [System.ComponentModel.DisplayName("e-mail")]

        public string email { get; set; } = String.Empty;
        [System.ComponentModel.DisplayName("Фамилия")]
        public string middleName { get; set; } = String.Empty;
        [System.ComponentModel.DisplayName("Адрес")]
        public string address { get; set; } = String.Empty;
        [System.ComponentModel.DisplayName("Телефон")]
        public string phone { get; set;  }= String.Empty;


        public override string ToString()
        {
            return $"{this.lastName} {this.firstName} {this.middleName}";
        }

    }
}
