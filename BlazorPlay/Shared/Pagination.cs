using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPlay.Shared
{
    public class Pagination
    {
        public int Page { get; set; } = 1;
        public int QuantityPerPage { get; set; } = 10;
    }
}
