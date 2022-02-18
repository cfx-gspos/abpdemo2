using TodoApp2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TodoApp2.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TodoApp2EntityFrameworkCoreModule),
    typeof(TodoApp2ApplicationContractsModule)
    )]
public class TodoApp2DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
