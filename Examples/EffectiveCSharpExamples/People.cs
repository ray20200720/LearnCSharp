using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCSharpExamples
{
    class People
    {
        public event EventHandler NameChanging;
        public event EventHandler NameChanged;

        private string _name;
        public string Name 
        { 
            get
            {
                lock(this)
                {
                    if (_name == null)
                        return string.Empty;
                    return _name;
                }
            }

            set
            {
                lock(this)
                {
                    if(_name != value)
                    {
                        NameChanging(this, new EventArgs());
                        _name = value;
                        NameChanged(this, new EventArgs());
                    }
                }
            }
        }
    }
}
