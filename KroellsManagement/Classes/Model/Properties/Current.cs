namespace KroellsManagement.Classes.Model.Properties
{
	/// <summary>
	/// This class represents an object of the currently selected table to display.
	/// It has seven attributes, just like the biggest table in the database.
	/// If a property is not used, it will be empty and not be displayed in the table on the website.
	/// </summary>
	public class Current
	{
		private string _one = "";
		private string _two = "";
		private string _three = "";
		private string _four = "";
		private string _five = "";
		private string _six = "";
		private string _seven = "";

		internal string One
		{
			get { return _one; }
			set { _one = value; }
		}

		internal string Two
		{
			get { return _two; }
			set { _two = value; }
		}
		internal string Three
		{
			get { return _three; }
			set { _three = value; }
		}
		internal string Four
		{
			get { return _four; }
			set { _four = value; }
		}
		internal string Five
		{
			get { return _five; }
			set { _five = value; }
		}
		internal string Six
		{
			get { return _six; }
			set { _six = value; }
		}
		internal string Seven
		{
			get { return _seven; }
			set { _seven = value; }
		}
	}
}
