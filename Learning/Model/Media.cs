using Learning.BaseBind;
using Learning.Helpers;

namespace Learning.Model
{
    public class Media : BindableBase
    {
        private int _id;
        private string _title;
        private string _author;
        private string _path;
        private MediaType _type;

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Author
        {
            get { return _author; }
            set { SetProperty(ref _author, value); }
        }

        public string Path
        {
            get { return _path; }
            set { SetProperty(ref _path, value); }
        }

        public MediaType MediaType { get { return _type; } set { SetProperty(ref _type, value); } }
        
    }
}
