using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> Item class </summary>
    public class Item : BaseClass
    {
        string _name = "";
        string _description = "";
        float _price = 0.0f;
        HashSet<string> _tags = new HashSet<string>();

        /// <summary> Item name </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary> Item description </summary>
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary> Item price </summary>
        public float price
        {
            get { return (float)Math.Round(_price, 2);}
            set { _price = value; }
        }

        /// <summary> Item tags </summary>
        public string[] tags
        {
            get {
                if (_tags.Count == 0)
                    return new string[0]; 
                return new List<string>(_tags).ToArray(); 
                }
            set { _tags = new HashSet<string>(value); }
        }


        /// <summary> Item constructor </summary>
        public Item(string name, string description = "", float price = 0.0f, string[] tags = null)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            if (tags != null)
                foreach (string tag in tags)
                    this._tags.Add(tag);
        }
    }
}