using System;
using Grace.DependencyInjection;
using Grace.DependencyInjection.Exceptions;
using Prism.Ioc;

namespace Prism.Grace
{
    /// <summary>
    /// Base bootstrapper class that uses <see cref="GraceContainerExtension"/> as it's container.
    /// </summary>
    public abstract class PrismBootstrapper : PrismBootstrapperBase
    {
        /// <summary>
        /// Create a new <see cref="GraceContainerExtension"/> used by Prism.
        /// </summary>
        /// <returns>A new <see cref="GraceContainerExtension"/>.</returns>
        protected override IContainerExtension CreateContainerExtension()
        {
            return new GraceContainerExtension(new DependencyInjectionContainer());
        }

        /// <summary>
        /// Registers the <see cref="Type"/>s of the Exceptions that are not considered 
        /// root exceptions by the <see cref="ExceptionExtensions"/>.
        /// </summary>
        protected override void RegisterFrameworkExceptionTypes()
        {
            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(LocateException));
        }
    }
}
