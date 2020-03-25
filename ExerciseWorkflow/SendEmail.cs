using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWorkflow
{
    class SendEmail:IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
