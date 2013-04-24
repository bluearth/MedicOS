using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MedicOS.Interface
{
    class InterfaceConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("name", IsKey=true, IsRequired=true)]
        public string Name { get; set; }

        [ConfigurationProperty("uuid", IsKey = true, IsRequired = true)]
        public string UUID { get; set; }
    }
}
