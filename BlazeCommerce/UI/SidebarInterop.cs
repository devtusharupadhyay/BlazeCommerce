using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeCommerce.UI
{
    public class SidebarInterop
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly ElementReference _sidebarReference;

        public SidebarInterop(IJSRuntime jsRuntime, ElementReference sidebarReference)
        {
            _jsRuntime = jsRuntime;
            _sidebarReference = sidebarReference;
        }

        public SidebarInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
            
        }


        
    }
}
