using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI.Example
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; } //cria identificador únidco do serviço
        ServiceLifetime Lifetime { get; } // tempo de vida do serviço
    }
}
