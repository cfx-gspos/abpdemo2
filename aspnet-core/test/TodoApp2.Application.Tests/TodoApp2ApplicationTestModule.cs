using Volo.Abp.Modularity;

namespace TodoApp2;

[DependsOn(
    typeof(TodoApp2ApplicationModule),
    typeof(TodoApp2DomainTestModule)
    )]
public class TodoApp2ApplicationTestModule : AbpModule
{

}
