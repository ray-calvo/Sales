namespace Sales.Infrastructure
{
    using Sales.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InstanceLocator
    {
        public MainViewModel Main{ get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
