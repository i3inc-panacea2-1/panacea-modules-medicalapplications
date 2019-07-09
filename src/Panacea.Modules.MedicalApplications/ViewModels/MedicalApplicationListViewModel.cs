using Panacea.Controls;
using Panacea.Core;
using Panacea.Modularity.Media.Channels;
using Panacea.Modularity.MediaPlayerContainer;
using Panacea.Modularity.UiManager;
using Panacea.Modularity.WebBrowsing;
using Panacea.Modules.MedicalApplications.Models;
using Panacea.Modules.MedicalApplications.Views;
using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Panacea.Modules.MedicalApplications.ViewModels
{
    [View(typeof(MedicalApplicationsList))]
    class MedicalApplicationListViewModel : ViewModelBase
    {
        public MedAppsItemProvider Provider { get; }

        public MedicalApplicationListViewModel(PanaceaServices core)
        {
            Provider = new MedAppsItemProvider(core);
            ItemClickCommand = new RelayCommand(args =>
            {
                var o = args as MedApp;
                switch (o.MedAppType)
                {
                    case "web":
                        if (o.Parameter.EndsWith(".mp4"))
                        {
                            if(core.TryGetMediaPlayerContainer(out IMediaPlayerContainer player))
                            {
                                player.Play(new MediaRequest(new IptvMedia() { URL = o.Parameter }));
                            }
                        }
                        else
                        {
                            if(core.TryGetWebBrowser(out IWebBrowserPlugin web))
                            {
                                web.OpenUnmanaged(o.Parameter);
                            }
                        }
                        break;
                    case "image":
                        if(core.TryGetUiManager(out IUiManager ui))
                        {
                            ui.Navigate(new ImageViewModel(o.ParameterThumbnail.Image), false);
                        }
                        break;

                }
            });
        }

        public ICommand ItemClickCommand { get; }
    }
}
