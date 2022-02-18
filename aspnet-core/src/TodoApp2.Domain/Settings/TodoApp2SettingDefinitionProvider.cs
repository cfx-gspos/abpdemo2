using Volo.Abp.Settings;

namespace TodoApp2.Settings;

public class TodoApp2SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TodoApp2Settings.MySetting1));
    }
}
