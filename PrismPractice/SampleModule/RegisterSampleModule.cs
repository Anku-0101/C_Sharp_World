using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModule
{
    /// <summary>
    /// Registers Module to prism shell (Main window)
    /// </summary>
    public class RegisterSampleModule : IModule
    {
        private IRegionManager _regionManager;

        public RegisterSampleModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("ModuleA", typeof(View.SampleView));
        }
    }
}
