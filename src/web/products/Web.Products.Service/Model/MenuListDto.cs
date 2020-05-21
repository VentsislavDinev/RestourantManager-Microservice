using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class MenuListViewModel
    {
        public IImmutableList<MenuViewModel> Menu { get; set; }
    }
}
