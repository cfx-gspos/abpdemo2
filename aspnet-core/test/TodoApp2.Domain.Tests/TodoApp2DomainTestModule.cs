using TodoApp2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TodoApp2;

[DependsOn(
    typeof(TodoApp2EntityFrameworkCoreTestModule)
    )]
public class TodoApp2DomainTestModule : AbpModule
{

}
