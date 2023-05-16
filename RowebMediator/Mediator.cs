using System;

namespace RowebMediator;

public abstract class Mediator
{
    protected readonly IServiceProvider _serviceProvider;

    public Mediator(IServiceProvider serviceProvider)
	{
        _serviceProvider = serviceProvider;
    }
}

