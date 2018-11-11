using System;
using System.Collections.Generic;

namespace desingpatterns.patterns.construction.Prototype
{
    public class EmptyDocumentation: Documentation
    {
        private static EmptyDocumentation _instance;

        public static EmptyDocumentation GetInstance()
        {
            if(_instance == null)
            {
                _instance = new EmptyDocumentation();
            }

            return _instance;
        }

        private EmptyDocumentation()
        {
            this.documents = new List<Document>();
        }

        public void add(Document document)
        {
            this.documents.Add(document);
        }

        public void remove(Document document)
        {
            this.documents.Remove(document);
        }

    }
}
