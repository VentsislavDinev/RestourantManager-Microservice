using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class ProductListDto
    {
        public IImmutableList<ProductsDto> Product { get; set; }
    }
}
