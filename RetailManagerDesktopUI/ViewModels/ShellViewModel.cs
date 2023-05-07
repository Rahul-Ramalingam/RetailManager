using Caliburn.Micro;
using RetailManagerDesktopUI.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.ViewModels
{
    public class ShellViewModel: Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesVM;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM)
        {
            _events = events;
            _salesVM = salesVM;

            //subscribe to the events published in this way the shell view model always listening to the event that are being published 
            _events.SubscribeOnPublishedThread(this);

            //Ioc talks to the container to bring in instances
            ActivateItemAsync(IoC.Get<LoginViewModel>());
        }

        //When clicked on login button the login method publishes a logonevent which triggers this function and the sales view model is activated
        public async Task HandleAsync(LogOnEvent message, CancellationToken cancellationToken)
        {
            await ActivateItemAsync(_salesVM);
        }
    }
}
