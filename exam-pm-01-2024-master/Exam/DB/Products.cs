using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DB
{
    internal class Products
    {
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("Наименование")]
        public string? title { get; set; }
        [System.ComponentModel.DisplayName("Категория")]
        public string? category { get; set; }
        [System.ComponentModel.DisplayName("Цена")]
        public decimal? price { get; set; }
        [System.ComponentModel.DisplayName("Количество в наличие")]
        public int amount { get; set; }
        

        public override string ToString()
        {
            return $"{this.title} - {this.category}";
        }
    }
}
