using System.ComponentModel;
using System.Runtime.CompilerServices;
using Learning.BaseBind;

namespace Learning.Model
{
    public class Customer :BindableBase
    {
        private int _id;
        private string _firstName;
        private string _lastName;


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

    }
}
