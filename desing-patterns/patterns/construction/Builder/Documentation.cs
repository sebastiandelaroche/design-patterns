using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.construction.Builder
{
    public abstract class Documentation
    {
        protected List<string> content = new List<string>();

        public abstract void add(string doc);
        public abstract void print();
    }
}
