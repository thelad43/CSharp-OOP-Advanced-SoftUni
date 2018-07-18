﻿namespace _01._Event_Implementation.Models
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs eventArgs);

    public class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (args != null)
            {
                this.NameChange(this, args);
            }
        }
    }
}