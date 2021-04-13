using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeCommerce.Shared
{
    public partial class Sidebar : ComponentBase
    {
        public ElementReference sidebarReference { get; set; }

        [Parameter]
        public string SidebarWidth
        {
            get { return _sidebarWidth; }
            set
            {
                _sidebarWidth = value;
                this.StateHasChanged();
            }
        }

        private string _sidebarWidth;

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }




        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
        }

        public void Close()
        {
            SidebarWidth = "0px";
        }

        public void Open()
        {
            SidebarWidth = "250px";
        }
    }
}
