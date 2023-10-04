namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object of a row from the job table, located in the database
	/// </summary>
	public class Job
	{
		private int _jobId;
		private int _income;
		private string _jobName;

		internal int JobId
		{
			get { return _jobId; }
			set { _jobId = value; }
		}

		internal int Income
		{
			get { return _income; }
			set { _income = value; }
		}

		internal string JobName
		{
			get { return _jobName; }
			set { _jobName = value; }
		}
	}
}
