using Panacea.ContentControls;
using Panacea.Core;
using Panacea.Modules.MedicalApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.MedicalApplications
{
    public class MedAppsItemProvider : HospitalServerLazyItemProvider<MedApp>
    {
        public MedAppsItemProvider(PanaceaServices core)
            : base(core, "MedApps/get_categories_only/", "MedApps/get_category_limited/{0}/{1}/{2}/", "", 10)
        {

        }

    }
}
