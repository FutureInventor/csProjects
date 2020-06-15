using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace storeOnline
{
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IValid => Validate();
        public enum EnityStateOption
        {
            Active,
            Deleted
        }
        public EnityStateOption EnityState { get; set; }
        public abstract bool Validate();
    }
}
