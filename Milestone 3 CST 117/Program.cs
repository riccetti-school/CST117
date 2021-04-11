using System;

namespace Milestone_3_CST_117
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager m = new InventoryManager();


            // lets add some inventory items
            m.Add(new InventoryItem() { Description = "One", Damaged = true });
            m.Add(new InventoryItem() { Description = "Two", Damaged = false });
            m.Add(new InventoryItem() { Description = "Three", Damaged = false });
            m.Add(new InventoryItem() { Description = "Four", Damaged = true });
            m.Add(new InventoryItem() { Description = "Five", Damaged = true });
            m.Add(new InventoryItem() { Description = "Six", Damaged = false });
            m.Add(new InventoryItem() { Description = "Seven", Damaged = false });
            m.Add(new InventoryItem() { Description = "Eight", Damaged = true });

            // display what we have
            m.Display();
        }
    }
}
