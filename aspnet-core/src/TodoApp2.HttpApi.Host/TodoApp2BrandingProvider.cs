using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoApp2;

[Dependency(ReplaceServices = true)]
public class TodoApp2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TodoApp2";
}
