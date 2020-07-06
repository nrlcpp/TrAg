using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrAg.Models
{
    public enum Importance
    {
        hight,
        medium,
        lower
    }
    public class Remark
    {
        public long Id { get; set; }
        public string Agent { get; set; }
        public string Content { get; set; }
        public Importance Importance { get; set; }
        public DateTime AddedOn { get; set; }
        public long ReservationId { get; set; }
        //public User AddedBy { get; set; }

        [JsonIgnore]
        public Booking Booking { get; set; }
    }
}
