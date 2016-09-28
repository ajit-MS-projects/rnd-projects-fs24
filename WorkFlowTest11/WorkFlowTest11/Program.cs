using System.Collections.Generic;
using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Threading;

namespace WorkFlowTest11
{

	class Program
	{
		/*static void Main(string[] args)
		{
			Console.Write("Please enter the data to pass the workflow: ");
			string wfData = Console.ReadLine();
			Dictionary<string, object> wfArgs = new Dictionary<string, object>();
			wfArgs.Add("MessageToShow", wfData);
			
			Activity workflow1 = new Workflow1();
			WorkflowInvoker.Invoke(workflow1, wfArgs);
		}*/
		static void Main(string[] args)
		{
			Console.Write("Please enter the data to pass the workflow: ");
			string wfData = Console.ReadLine();
			Dictionary<string, object> wfArgs = new Dictionary<string, object>();
			wfArgs.Add("MessageToShow", wfData);

			AutoResetEvent waitHandle = new AutoResetEvent(false);
			// Pass to the workflow.
			WorkflowApplication app = new WorkflowApplication(new Workflow1(), wfArgs);
			// Hook up an event with this app.
			// When I'm done, notifiy other thread I'm done,
			// and print a message.
			app.Completed = (completedArgs) =>
			{
				waitHandle.Set();
				Console.WriteLine("The workflow is done!");
			};

			app.Run();
			// Wait until I am notified the workflow is done.
			waitHandle.WaitOne();
			Console.WriteLine("Thanks for playing");
		}
	}
}
