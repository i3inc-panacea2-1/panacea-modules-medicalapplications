using Panacea.Core;
using Panacea.Modularity.UiManager;
using Panacea.Modules.MedicalApplications.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.MedicalApplications
{
    class MedicalApplicationsPlugin : ICallablePlugin
    {
        private readonly PanaceaServices _core;

        public MedicalApplicationsPlugin(PanaceaServices core)
        {
            _core = core;
        }

        public Task BeginInit()
        {
            return Task.CompletedTask;
        }

        public void Call()
        {
            if(_core.TryGetUiManager(out IUiManager ui))
            {
                ui.Navigate(new MedicalApplicationListViewModel(_core));
            }
        }

        public void Dispose()
        {
            
        }

        public Task EndInit()
        {
            return Task.CompletedTask;
        }

        public Task Shutdown()
        {
            return Task.CompletedTask;
        }
    }
}
