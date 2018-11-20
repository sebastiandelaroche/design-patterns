using System;
namespace desingpatterns.patterns.structuring.Facade
{
    public class DocumentManagementComponent : DocumentManagement
    {
        public string document(int index)
        {
            return $"Document number: {index}";
        }
    }
}
