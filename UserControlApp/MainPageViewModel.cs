using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlApp
{
    public class MainPageViewModel: BindableBase
    {
        private int toasted = 50000;
        private int roasted = 150;
        private int posted = 4380;


        public int Toasted {
            get { return this.toasted; }
            set { this.SetProperty(ref this.toasted, value); }
        }

        public int Roasted
        {
            get { return this.roasted; }
            set { this.SetProperty(ref this.roasted, value); }
        }

        public int Posted
        {
            get { return this.posted; }
            set { this.SetProperty(ref this.posted, value); }
        }
    }
}
