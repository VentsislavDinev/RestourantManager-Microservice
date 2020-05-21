using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class MenuListDto
    {
        public IImmutableList<MenuDto> Menu { get; set; }
    }
}
