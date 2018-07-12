using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PosUP_CloudComputing_WebAPIDotNET.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}