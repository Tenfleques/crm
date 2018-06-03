using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm {
    public static class Constants {
        public static String defaultTxtQueryText = "Опишите список клиентов, необходимых для этой группы. Менеджер базы данных запрограммирует список для вас.";

        public static Dictionary<string, string> specialOfferCategories = new Dictionary<string, string>(){
            { "No discount", "Нет скидки" },
            { "Reseller", "Торговый посредник"},
            { "Customer", "Клиент"}
        };
        public static Dictionary<string, string> specialOfferTypes = new Dictionary<string, string>(){
            { "No discount", "Нет скидки" },
            { "Volume Discount", "Объемная скидка"},
            { "Discontinued Product", "продукт снятый с производства"},
            { "Seasonal Discount", "Сезонная скидка"},
            { "Excess Inventory", "Избыточный инвентарь"},
            { "New Product", "Новый продукт"}
        };
    }
}
