using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        public void Buy(Order order)
        {
            Console.WriteLine("Sipariş oluşturuldu.");
        }

        public void Delete(Order order)
        {
            Console.WriteLine("Sipariş başarıyla silindi. " );
        }

        public void Update(Order order)
        {
            Console.WriteLine("Sipariş başarıyla güncellendi. " );
        }
    }
}
