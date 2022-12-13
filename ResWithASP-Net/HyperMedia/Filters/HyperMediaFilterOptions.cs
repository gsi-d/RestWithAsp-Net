using ResWithASP_Net.HyperMedia.Abstract;
using System.Collections.Generic;

namespace ResWithASP_Net.HyperMedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
