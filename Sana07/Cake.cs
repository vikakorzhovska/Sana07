using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class Cake : Product
    {
        public string Filling {  get; set; }
        public DateTime DateOfManufacture { get; set; }
        public override string Display()
        {
            return $"Назва: {Name} || Начинка: {Filling} || Дата виготовлення: {DateOfManufacture} || Ціна: {Price} || Кількість: {Count}";
        }
        public Cake(string name, decimal price, int count, string filling, DateTime dateOfManufacture) : base(name, price, count)
        {
            Filling = filling ;
            DateOfManufacture = dateOfManufacture ;
        }
    }
}
