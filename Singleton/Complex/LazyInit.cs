using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Complex
{
    public class LazyInit
    {
        private static readonly Lazy<LazyInit> lazyInstance = new Lazy<LazyInit>(() => new LazyInit());

        private LazyInit() { }

        public static LazyInit Instance => lazyInstance.Value;
    }
}
