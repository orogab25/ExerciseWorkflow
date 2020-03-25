using System;
using System.Collections.Generic;

namespace ExerciseWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            WokflowEngine wokflowEngine = new WokflowEngine();
            List<IWorkflowObject> list = new List<IWorkflowObject>();
            list.Add(new UploadVideo());
            list.Add(new CallWebService());
            list.Add(new SendEmail());
            list.Add(new ChangeStatus());

            wokflowEngine.Run(list);
        }
    }
}
