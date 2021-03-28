using System;

namespace Milestone_2_CST_117
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new InventoryItem();

            item.Barcode = "0001";
            if (item.Barcode != "0001")
                Console.WriteLine("Barcode Failed");
            else
                Console.WriteLine("Barcode Passed");

            item.Damaged = true;
            if(item.Damaged)
                Console.WriteLine("Damanged Passed");
            else
                Console.WriteLine("Damaged Failed");

            var guid = item.Id.ToString();
            if(guid != item.Id.ToString())
                Console.WriteLine("Id Failed");
            else
                Console.WriteLine("Id Passed");

            item.PackageSize = 10;
            if(item.PackageSize != 10)
                Console.WriteLine("PackageSize Failed");
            else
                Console.WriteLine("PackageSize Passed");

            item.Ship(true);
            if(!item.Shipped)
                Console.WriteLine("Shipped Failed");
            else
                Console.WriteLine("Shipped Passed");

            item.UnitSize = 1;
            if(item.UnitSize != 1)
                Console.WriteLine("UnitSize Failed");
            else
                Console.WriteLine("UnitSize Passed");

            item.UnitType = "OZ";
            if(item.UnitType != "OZ")
                Console.WriteLine("UnitType Failed");
            else
                Console.WriteLine("UniTType Passed");

            item.Description = "Peas";
            if(item.Description != "Peas")
                Console.WriteLine("Description Failed");
            else
                Console.WriteLine("Description Passed");

            item.Damaged = false;
            if(!item.Damaged)
                Console.WriteLine("Damaged Passed");
            else
                Console.WriteLine("Damaged Failed");

        }
    }
}
