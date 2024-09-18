using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class Pagenation
    {
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get;  set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public string? PrevoisPageLink { get; set; }
        public string? NextPageLink { get; set; }
        public string ToJsonString()
        {
            HasPrevious = CurrentPage > 1;
            HasNext = CurrentPage < TotalPages;
            var res = JsonConvert.SerializeObject(this);
            return res.Replace(",", "\\002C");
        }
    }
}
