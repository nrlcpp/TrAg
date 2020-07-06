using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrAg.Models
{
    public enum Type
    {
        circuit,
        stay,
        accommodation,
        others
    }
    public enum Currency
    {
        EUR,
        RON,
        USD
    }
    public class Booking
    {
        public long Id { get; set; }

        //   public string Description { get; set; }

        public long Sum { get; set; }

        public string Location { get; set; }

        public DateTime AddedOn { get; set; }

        public Currency Currency { get; set; }

        public Type Type { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public bool Documents { get; set; }

       // public User AddedBy { get; set; }

        public List<Remark> Remarks { get; set; }
    }
}
