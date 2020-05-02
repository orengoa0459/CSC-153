using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameRoom
    {
        //Fields
        private string _roomName;
        private string _roomDescription;
        //Constructors
        public GameRoom()
        {
            RoomName = "";
            RoomDescription = "";
        }
        public GameRoom(string roomName, string roomDescription)
        {
            RoomName = roomName;
            RoomDescription = roomDescription;
        }

        public string RoomName
        {
            get
            {
                return _roomName;
            }
            set
            {
                _roomName = value;

            }
        }
        public string RoomDescription
        {
            get
            {
                return _roomDescription;
            }
            set
            {
                _roomDescription = value;

            }
        }
    }
}
