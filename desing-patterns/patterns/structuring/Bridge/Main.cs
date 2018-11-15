using System;
namespace desingpatterns.patterns.structuring.Bridge
{
    public class Main
    {
        public void execute()
        {
            EnrollmentFormSpain form1 = new EnrollmentFormSpain(new HTMLImplementForm());
            form1.visualize();

            if (form1.manageZone()) {
                form1.generateDocument();
                Console.WriteLine();
            }

            EnrollmentFormPortugal form2 = new EnrollmentFormPortugal(new AppletImplementForm());
            form2.visualize();

            if (form2.manageZone())
            {
                form2.generateDocument();
                Console.WriteLine();
            }

        }
    }
}
