using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace houselongexercise_pg332
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        
        public Location DoorLocation{get; set;}


        public string DoorDescription { get; private set; }


        public RoomWithDoor(string name, string decoration, string hidingPlaceName, 
            string doorDescription)
            : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

    }
}
