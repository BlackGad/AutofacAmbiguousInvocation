using Autofac;

namespace AutofacAmbiguousInvocation
{
    public class Example
    {
        #region Constructors

        public Example()
        {
            ILifetimeScope scope = null;
            var instance = scope.ResolveOptional<IInterface>();
        }

        #endregion
    }

    internal interface IInterface
    {
    }
}