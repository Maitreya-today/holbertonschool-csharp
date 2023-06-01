using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary> User class </summary>
    public class User : BaseClass
    {
        string _name = "user";
        
        ///<summary> User name </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary> User constructor </summary>
        public User(string name)
        {
            if(name != null)
                this.name = name;
        }
    }
}