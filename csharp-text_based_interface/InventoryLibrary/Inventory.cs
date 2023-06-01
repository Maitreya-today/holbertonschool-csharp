using System;


namespace InventoryLibrary
{

    /// <Summary> Inventory class </Summary>
    public class Inventory : BaseClass
    {
        string _user_id = "";
        string _item_id = "";
        int _quantity = 1;

        /// <summary> User id </summary>
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        /// <summary> Item id </summary>
        public string item_id
        {
            get { return _item_id; }
            set { _item_id = value; }
        }

        /// <summary> Quantity </summary>
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = Math.Max(value, 0); }
        }

        /// <summary> Inventory constructor </summary>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            this.quantity = quantity;
        }

        /// <summary> Inventory constructor </summary>
        public Inventory(User user, Item item, int quantity = 1)
        {
            this.user_id = user.id;
            this.item_id = item.id;
            this.quantity = quantity;
        }
    }
}using System.Text.Json;

//namespace InventoryLibrary
//{
/// <summary>
/// This is the class used to create inventories.
/// </summary>
public class Inventory : BaseClass
{
    public User user { get; set; }
    public Item item { get; set; }
    public int quantity { get; set; }
    public string user_id { get; set; }
    public string item_id { get; set; }

    /// <summary>
    /// Class Constructor.
    /// </summary>
    /// <param name="user_id">User ID.</param>
    /// <param name="item_id">Item ID.</param>
    /// <param name="quantity">Item Quantity.</param>
    public Inventory(User user = null, Item item = null, int quantity = 1)
    {
        if (quantity < 0)
            quantity = 1;

        this.quantity = quantity;
        if (user != null)
            this.user_id = user.id;
        else
            this.user_id = "Default_Item_Id";
        if (item != null)
            this.item_id = item.id;
        else
            this.item_id = "Default_Item_Id";
    }

    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nOwn Id: {this.id}\nUser Id: {this.user_id}\nItem Id: {this.item_id}\nItem Quiantity: {this.quantity}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }

}
//}