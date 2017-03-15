using Dragablz;

namespace DragablzCustomTab
{
    class MainWindowViewModel
    {
        public IInterTabClient InterTabClient { get; set; }
        public MainWindowViewModel()
        {
            InterTabClient = new MainInterTabClient();
        }
    }
}
