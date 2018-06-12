using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm {
    public static class Constants {
        public static int defaultSupportID = 275;
        public static String recordWrittenToDB (int recordsAffected) {
            return "Зафиксированные записи: " + recordsAffected;
        }
        public static Dictionary<String, int> customerRecordSuppotIndices = new Dictionary<string, int>() {
            { "BusinessEntityID",0},
            { "PhoneNumber",1 },
            { "EmailAddress",2},
            { "City",3 },
            { "StateProvinceName", 4},
            { "CountryRegionName", 5},
            { "name" ,6},
            {"supportid",7},
            {"message",8},
            {"date",9},
            {"messageid",10},
            {"replyto",11},
            {"clientwritten",12 },
            {"support",13 }
        };

        public static String searchCustromerBoxDefaultText = "найти клиента..."; 
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
