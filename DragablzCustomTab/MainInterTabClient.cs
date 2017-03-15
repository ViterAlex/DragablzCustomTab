using System.Windows;
using Dragablz;

namespace DragablzCustomTab
{
    class MainInterTabClient : IInterTabClient
    {
        public INewTabHost<System.Windows.Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var view = new TabHostWindow();
            return new NewTabHost<TabHostWindow>(view, view.TabsContainer);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}
