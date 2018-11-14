using System;
namespace desingpatterns.patterns.structuring.Adapter
{
    public class HTMLDocument: Document
    {
        protected string _content;


        public string content 
        { 
            get
            {
                return this._content;
            }
            set 
            {
                this._content = value;
            }
        }

        public void draw()
        {
            Console.WriteLine($"Draw the HTML document: {this.content}");
        }

        public void print()
        {
            Console.WriteLine($"Print the HTML document: {this.content}");
        }
    }
}
