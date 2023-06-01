using System;

namespace InventoryLibrary
{
    /// <summary> BaseClass class </summary>
    public class BaseClass
    {
        /// <summary> BaseClass id </summary>
        public string id { get;}

        /// <summary> date created </summary>
        public DateTime date_created { get;}

        /// <summary> date updated </summary>
        public DateTime date_updated { get;}
    
        /// <summary> BaseClass constructor </summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            DateTime curent = DateTime.Now;
            this.date_created = curent;
            this.date_updated = curent;
        }
            
    }
}