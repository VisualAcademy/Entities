using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class OrderDemo
    {
        public int Id { get; set; }

        public DateTimeOffset OrderDate { get; set; }

        public string OrderNumber { get; set; }

        public string Status { get; set; }

        public long SalesId { get; set; }
    }
}
