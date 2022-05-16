using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component restaurantBranch1 = new Composite("Branch1");
            // определяем новый диск
            Component Date = new Composite("Date");
            restaurantBranch1.Add(Date);
            // новые файлы
            Component date1 = new Composite("02.05.22");
            Component date2 = new Composite("03.05.22");
            Component date3 = new Composite("04.05.22");
            // добавляем файлы на диск С
            Date.Add(date1);
            Date.Add(date2);
            Date.Add(date3);
            Component profit1 = new Info("12000");
            date1.Add(profit1);
            Component profit2 = new Info("35000");
            date2.Add(profit2);
            Component profit3 = new Info("34000");
            date3.Add(profit3);
            Date.Remove(date3);
            // выводим все данные
            restaurantBranch1.Print();
        }
    }
}