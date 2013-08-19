using System;
using System.Collections.Generic;

namespace Core.Models
{
    public partial class Setting
    {
        public int SettingId { get; set; }
        public string SettingType { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
