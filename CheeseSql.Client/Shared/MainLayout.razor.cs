using System;

namespace CheeseSql.Client.Shared
{
    public partial class MainLayout : IDisposable
    {
        private bool _drawerOpen = true;

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}