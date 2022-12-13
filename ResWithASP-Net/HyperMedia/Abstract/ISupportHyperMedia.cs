using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResWithASP_Net.HyperMedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
