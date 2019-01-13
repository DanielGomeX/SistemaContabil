using Microsoft.Extensions.DependencyInjection;
using SistemaContabil.Application.AppServices;
using SistemaContabil.Application.Contracts;
using SistemaContabil.Core.Aggregates.Fiscal.Contracts;
using SistemaContabil.Core.Aggregates.Fiscal.Repositories;
using SistemaContabil.Core.Aggregates.Fiscal.Services;
using SistemaContabil.Core.Contracts;
using SistemaContabil.Core.SharedKernel.Contracts;
using SistemaContabil.Core.SharedKernel.Notifications;
using SistemaContabil.Infra.Data;
using SistemaContabil.Infra.Data.Repositories;

namespace SistemaContabil.Infra.IoC
{
    public static class DependencyInjector
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<INotificationHandler, NotificationHandler>();
            services.AddScoped<INotaFiscalRepository, NotaFiscalRepository>();
            services.AddScoped<INotaFiscalService, NotaFiscalService>();
            services.AddScoped<INotaFiscalAppService, NotaFiscalAppService>();
        }
    }
}
