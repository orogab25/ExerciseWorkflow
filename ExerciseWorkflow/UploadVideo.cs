using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWorkflow
{
    class UploadVideo:IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}
