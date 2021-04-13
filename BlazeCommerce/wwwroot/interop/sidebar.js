

var sidebarInterop = sidebarInterop || {};

sidebarInterop.toogle = function () {
    try {
        let sidebar = document.getElementById('bcSidebar');
        sidebar.style.width = '250px';

    } catch (e) {
        sidebar.style.width = '0px';
    }
}