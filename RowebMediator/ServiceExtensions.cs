using System.Reflection;

namespace RowebMediator;

public static class ServiceExtensions
{
    public static void AddMediator(this IServiceCollection services)
    {
        List<Type> typesImplementingIRepository = new List<Type>();
        IEnumerable<Type> allTypesInThisAssembly = Assembly.GetCallingAssembly().GetTypes();

        foreach (Type type in allTypesInThisAssembly)
        {
            if (type.GetInterface(typeof(IHandler<,>).Name.ToString()) != null)
            {
                services.AddTransient(type);
            }
        }
        var mediatorType = allTypesInThisAssembly.First(x => x.BaseType == typeof(Mediator));
        services.AddTransient(mediatorType);
    }
}

