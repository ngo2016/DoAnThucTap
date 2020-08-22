using DoAnThucTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnThucTap.ViewModel
{
    public class RDViewModel
    {
        public IEnumerable<TY_LE_CHI_RD> RDCost { get; set; }
        public IEnumerable<TY_LE_LAO_DONG_RD> RDEmployee { get; set; }
    }
}