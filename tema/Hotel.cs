using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema
{
    public class Hotel : ICloneable
    {
        public Hotel()
        {
            this.Rooms = new List<Room>();
        }
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public object Clone()
        {
            var h = new Hotel();
            h.Name = this.Name;
            for (int i = 0; i < this.Rooms.Count; i++)
            {
                var r = new Room();
                r.Price = this.Rooms[i].Price;
                r.Currency = this.Rooms[i].Currency;
                h.Rooms.Add(r);
            }

            return (Object)h;

        }
    }
}
