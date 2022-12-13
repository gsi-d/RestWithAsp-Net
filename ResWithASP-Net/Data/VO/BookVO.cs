using ResWithASP_Net.HyperMedia;
using ResWithASP_Net.HyperMedia.Abstract;
using System.Collections.Generic;

namespace ResWithASP_Net.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
