using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.D0017.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="FunctionalVisualStudioProjectFileSerializationModifier"/> implementation of <see cref="IFunctionalVisualStudioProjectFileSerializationModifier"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddFunctionalVisualStudioProjectFileSerializationModifier(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IFunctionalVisualStudioProjectFileSerializationModifier, FunctionalVisualStudioProjectFileSerializationModifier>()
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="FunctionalVisualStudioProjectFileSerializationModifier"/> implementation of <see cref="IFunctionalVisualStudioProjectFileSerializationModifier"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IFunctionalVisualStudioProjectFileSerializationModifier> AddFunctionalVisualStudioProjectFileSerializationModifierAction(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction<IFunctionalVisualStudioProjectFileSerializationModifier>.New(() => services.AddFunctionalVisualStudioProjectFileSerializationModifier(stringlyTypedPathOperatorAction));
            return serviceAction;
        }
    }
}
