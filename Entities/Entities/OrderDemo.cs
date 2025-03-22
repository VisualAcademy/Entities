using System;

namespace Entities
{
    public class OrderDemo
    {
        public int Id { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public string Status { get; set; }

        public long SalesId { get; set; }
    }
}
