using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public class EnrollmentFormPortugal: EnrollmentForm
    {
        public EnrollmentFormPortugal(ImplementForm implementForm): base(implementForm) { }

        protected override bool controlZone(string enrollment)
        {
            return enrollment.Length > 6;
        }
    }
}
