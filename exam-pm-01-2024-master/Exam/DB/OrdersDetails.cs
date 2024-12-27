using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DB
{
    internal class OrdersDetails
    {
        [System.ComponentModel.DisplayName("ID")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("ID Заказа")]
        public int idOrder { get; set; }

        [System.ComponentModel.DisplayName("ID Продукции")]
        public int idProduction { get; set; }
        [System.ComponentModel.DisplayName("Количество")]
        public int amount { get; set; }

    }
}
