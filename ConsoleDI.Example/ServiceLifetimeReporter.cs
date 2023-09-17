using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI.Example
{
    internal sealed class ServiceLifetimeReporter
    {
        private readonly IExampleScopedService _scopedService;
        private readonly IExampleTransientService _transienteService;
        private readonly IExampleSingletonService _singletonService;

        public ServiceLifetimeReporter(
            IExampleScopedService scopedService,
            IExampleTransientService transientService,
            IExampleSingletonService singletonService) =>
            (_scopedService, _transienteService, _singletonService) =
            (scopedService, transientService, singletonService);

        public void ReportServiceLifetimeDatails(string lifetimeDatails)
        {
            Console.WriteLine(lifetimeDatails);

            LogService(_transienteService, "Changes only with lifetime");
            LogService(_transienteService, "always different");
            LogService(_singletonService, "always the same");
        }

        private static void LogService<T>(T service, string message)
            where T : IReportServiceLifetime => Console.WriteLine($"{typeof(T).Name}: {service.Id} ({message})");
    }
}
