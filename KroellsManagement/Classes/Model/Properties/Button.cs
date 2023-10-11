namespace KroellsManagement.Classes.Model.Properties
{
    /// <summary>
    /// This class represents a button object.
    /// A button has a name.
    /// </summary>
    internal class Button
    {
        private string _buttonName;

        internal string ButtonName
        {
            get { return _buttonName; }
            set { _buttonName = value; }
        }
    }
}
