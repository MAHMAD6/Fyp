using System;
using System.Collections.Generic;

namespace Project_Pulse.BL.Abstract
{
    public class Group
    {
        public int ID { get; set; }
        public DateTime Created_ON { get; set; }
        public List<GroupStudent> Students { get; set; } = new List<GroupStudent>();
        public Group(int id, DateTime created_on)
        {
            ID = id;
            Created_ON = created_on;
        }

    }
}
