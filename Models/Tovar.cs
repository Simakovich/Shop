using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Tovar
    {
        public int Id { get; set; }
        public float Cost { get; set; } // цена
        public string Brend { get; set; } // фирма изготовитель
        public  int Entrepot { get; set; } //количество на складе
        public string Name { get; set; } // наименование товара
        public string Section { get; set; } // секия товара
        public string Unit { get; set; } // единица измерения
        public string Remark { get; set; } //служебное поле

    }
}
