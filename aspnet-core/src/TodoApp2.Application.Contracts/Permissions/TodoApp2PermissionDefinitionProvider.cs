using TodoApp2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TodoApp2.Permissions;

public class TodoApp2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TodoApp2Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TodoApp2Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TodoApp2Resource>(name);
    }
}
