using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using Learning.BaseBind;

namespace Learning.Model
{
    public class Customer :BindableBase
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _workedHours;
      
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        public DateTime WorkedHours
        {
            get { return _workedHours; }
            set { SetProperty(ref _workedHours, value); }
        }
    }
}
