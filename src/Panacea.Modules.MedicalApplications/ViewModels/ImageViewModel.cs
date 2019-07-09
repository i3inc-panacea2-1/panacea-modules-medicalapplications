using Panacea.Modules.MedicalApplications.Views;
using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.MedicalApplications.ViewModels
{
    [View(typeof(ImageView))]
    class ImageViewModel:ViewModelBase
    {
        public string Url { get; set; }

        public ImageViewModel(string url)
        {
            Url = url;
        }
    }
}
