using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoApp2.Data;

/* This is used if database provider does't define
 * ITodoApp2DbSchemaMigrator implementation.
 */
public class NullTodoApp2DbSchemaMigrator : ITodoApp2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
