﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_2_CST_117
{
    public class InventoryItem
    {
        // id of th item
        public Guid Id { get; internal set; }

        // how many of this item to a package
        public int PackageSize { get; set; }

        // description of this item
        public string Description { get; set; }

        // item unit size, individually
        public float UnitSize { get; set; }

        // unit type, .oz .lbs
        public string UnitType { get; set; }

        // barcode value
        public string Barcode { get; set; }

        // is this item damaged
        public bool Damaged { get; set; }

        public bool Shipped { get; internal set; }

        // has this item shipped
        public void Ship(bool shipIt)
        {
            Shipped = shipIt;
        }

        public InventoryItem()
        {
            Id = Guid.NewGuid();
        }
    }
}
