using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApp2.Data;
using Volo.Abp.DependencyInjection;

namespace TodoApp2.EntityFrameworkCore;

public class EntityFrameworkCoreTodoApp2DbSchemaMigrator
    : ITodoApp2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTodoApp2DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the TodoApp2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TodoApp2DbContext>()
            .Database
            .MigrateAsync();
    }
}
