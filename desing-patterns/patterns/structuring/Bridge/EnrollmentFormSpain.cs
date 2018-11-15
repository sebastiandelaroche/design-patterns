using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public class EnrollmentFormSpain: EnrollmentForm
    {
        public EnrollmentFormSpain(ImplementForm implementForm): base (implementForm) { }

        protected override bool controlZone(string enrollment)
        {
            return enrollment.Length < 7;
        }
    }
}
