using System;

public interface IInventory
{

    public int id { get; set; }

    public string description { get; set; }

    public string location { get; set; }

    public int quantity { get; set; }

    public bool onOrder { get; set; }

}
