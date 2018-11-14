using System;
namespace desingpatterns.patterns.structuring.Adapter
{
    public interface Document
    {
        string content { set; }
        void draw();
        void print();
    }
}
