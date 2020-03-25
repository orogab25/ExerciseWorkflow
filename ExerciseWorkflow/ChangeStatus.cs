using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWorkflow
{
    class ChangeStatus:IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}
