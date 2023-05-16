using System;
using RowebMediator;

namespace MediatorExample.Services
{
    public partial class AppMediator : Mediator
    {
        public AppMediator(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            
        }
    }
}

