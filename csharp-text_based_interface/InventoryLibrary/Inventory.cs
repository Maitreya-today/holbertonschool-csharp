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
}