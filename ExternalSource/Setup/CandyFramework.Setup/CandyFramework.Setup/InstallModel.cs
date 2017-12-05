using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyFramework.Setup
{
    public class InstallModel
    {
        public InstallModel()
        {
            this.LabelText = string.Empty;
        }
        public int BarSize { get; set; }
        public string LabelText { get; set; }
    }
}
