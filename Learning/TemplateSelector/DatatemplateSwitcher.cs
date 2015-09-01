using System.Windows;
using System.Windows.Controls;
using Learning.Helpers;
using Learning.Model;

namespace Learning.TemplateSelector
{
    public class DatatemplateSwitcher : DataTemplateSelector
    {
        public DataTemplate ImageTemplate { get; set; }
        public DataTemplate VideoTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement template = container as FrameworkElement;

            var listItem = item as Media;
            if (template == null || listItem == null) return null;
            
            if (listItem.MediaType == MediaType.Image)
            {
                return ImageTemplate = template.FindResource("ImageTemplate") as DataTemplate;
            }
            return VideoTemplate = template.FindResource("VideoTemplate") as DataTemplate;
        }
    }
}
