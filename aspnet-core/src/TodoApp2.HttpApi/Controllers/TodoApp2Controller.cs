using TodoApp2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoApp2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoApp2Controller : AbpControllerBase
{
    protected TodoApp2Controller()
    {
        LocalizationResource = typeof(TodoApp2Resource);
    }
}
