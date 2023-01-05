using Grace.DependencyInjection;
using Prism.Ioc;

namespace Prism.Grace;

/// <summary>
///     Extensions help get the underlying <see cref="IInjectionScope" />
/// </summary>
public static class PrismIocExtensions
{
    /// <summary>
    ///     Gets the <see cref="IInjectionScope" /> from the <see cref="IContainerProvider" />
    /// </summary>
    /// <param name="containerProvider">The current <see cref="IContainerProvider" /></param>
    /// <returns>The underlying <see cref="IInjectionScope" /></returns>
    public static IInjectionScope GetContainer(this IContainerProvider containerProvider)
    {
        return ((IContainerExtension<IInjectionScope>)containerProvider).Instance;
    }

    /// <summary>
    ///     Gets the <see cref="IInjectionScope" /> from the <see cref="IContainerProvider" />
    /// </summary>
    /// <param name="containerRegistry">The current <see cref="IContainerRegistry" /></param>
    /// <returns>The underlying <see cref="IInjectionScope" /></returns>
    public static IInjectionScope GetContainer(this IContainerRegistry containerRegistry)
    {
        return ((IContainerExtension<IInjectionScope>)containerRegistry).Instance;
    }
}