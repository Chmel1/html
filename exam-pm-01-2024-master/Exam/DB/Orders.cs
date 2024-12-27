using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DB
{
    public enum OrderStatus
    {
        Pending = 0,   // Ожидает
        Shipped = 1,   // Отправлено
        Delivered = 2, // Доставлено
        Canceled = 3   // Отменено
    }


    internal class Orders
    {
        [System.ComponentModel.DisplayName("ID_Заказы")]
        public int id { get; set; }
        [System.ComponentModel.DisplayName("ID_Клиента")]
        public int idClients { get; set; }
        [System.ComponentModel.DisplayName("Дата заказа")]
        [Column(TypeName = "timestamp with time zone")]
        public DateTime dateOrder { get; set; }
        
        [System.ComponentModel.DisplayName("Статус")]
        public  OrderStatus Status { get; set; }

    }
}
