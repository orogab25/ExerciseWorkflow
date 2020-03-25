using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWorkflow
{
    class CallWebService:IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }
}
