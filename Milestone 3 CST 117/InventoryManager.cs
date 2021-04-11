using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3_CST_117
{
    public class InventoryManager
    {

        private InventoryItem[] items = null;

        public void Add(InventoryItem i)
        {
            if (items == null)
            {
                items = new InventoryItem[1];
                items[0] = i;
            }
            else
            {
                var l = items.Length + 1;
                Array.Resize<InventoryItem>(ref items, l);
                items[l-1] = i;
                //InventoryItem[] temp = new InventoryItem[l + 1];
                //for (int j = 0; j < l; j++)
                //{
                //    temp[j] = items[j];
                //}

                //temp[l + 1] = i;

                //Array.Resize<InventoryItem>(ref items, l + 1);
                //temp.CopyTo(items, 0);
            }
        }

        public void Remove(Guid id)
        {
            if (items == null) return;

            if (items.Any(c => c.Id.ToString() == id.ToString()))
            {
                InventoryItem[] temp = new InventoryItem[items.Length - 1];
                for (int i = 0; i < items.Length; i++)
                {
                    if (items[i].Id != id)
                    {
                        temp[i] = items[i];
                    }
                }

                items = new InventoryItem[items.Length - 1];
                temp.CopyTo(items, 0);
            }

        }

        public void Display()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }

        public void Search(string description, bool damaged)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Description == description && items[i].Damaged == damaged)
                {
                    Console.WriteLine(items[i].ToString());
                    return;
                }
                Console.WriteLine($"Did not find {description} with a damage value of {damaged}");
            }
        }

    }
}
