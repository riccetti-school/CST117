using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3_CST_117
{
    public class InventoryManager
    {

        public List<InventoryItem> items = new List<InventoryItem>();

        public void Add(InventoryItem i)
        {

            items.Add(i);

        }

        public void Remove(Guid id)
        {
            if (items.Any(c => c.Id == id))
                items.Remove(items.First(c => c.Id == id));

        }

        public void Display()
        {
            foreach(var i in items)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void Search(string description, bool damaged)
        {
            if(items.Any(c=>c.Description == description && c.Damaged == damaged))
            {
                Console.WriteLine(items.First(c => c.Description == description && c.Damaged == damaged).ToString());
                return;
            }

            Console.WriteLine($"Did not find {description} with a damage value of {damaged}");
        }

    }
}
