using System.Collections.Generic;
using Learning.Helpers;
using Learning.Model;

namespace Learning.ViewModel
{
    public class MediaViewModel
    {
        public MediaViewModel()
        {
            MediaList = new List<Media>
            {
                new Media{Id = 1, Author = "Alex", Path = "/Resources/star.ico", Title = "Star", MediaType = MediaType.Image},
                new Media{Id = 2, Author = "Alex", Path = "/Resources/linux.png", Title = "Linux", MediaType = MediaType.Image},
                new Media{Id = 3, Author = "Alex", Path = "/Resources/stackerror-firstStep.swf", Title = "Swf video", MediaType = MediaType.Video}
            };
        }

        public List<Media> MediaList { get; set; }
    }
}
