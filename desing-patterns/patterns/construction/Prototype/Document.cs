using System;
namespace desingpatterns.patterns.construction.Prototype
{
    public abstract class Document
    {
        protected string content;

        public abstract void print();
        public abstract void visualize();

        public Document clone()
        {
            return (Document)this.MemberwiseClone();
        }

        public void fill(string info)
        {
            this.content = info;
        }
    }
}
