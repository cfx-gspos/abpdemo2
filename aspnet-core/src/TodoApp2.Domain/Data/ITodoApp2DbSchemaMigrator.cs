using System.Threading.Tasks;

namespace TodoApp2.Data;

public interface ITodoApp2DbSchemaMigrator
{
    Task MigrateAsync();
}
