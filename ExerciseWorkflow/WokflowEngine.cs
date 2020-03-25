using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWorkflow
{
    class WokflowEngine
    {
        public void Run(List<IWorkflowObject> workflow)
        {
            foreach(IWorkflowObject workflowObject in workflow)
            {
                workflowObject.Execute();
            }
        }
    }
}
