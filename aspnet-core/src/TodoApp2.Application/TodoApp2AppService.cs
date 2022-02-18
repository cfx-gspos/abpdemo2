using System;
using System.Collections.Generic;
using System.Text;
using TodoApp2.Localization;
using Volo.Abp.Application.Services;

namespace TodoApp2;

/* Inherit your application services from this class.
 */
public abstract class TodoApp2AppService : ApplicationService
{
    protected TodoApp2AppService()
    {
        LocalizationResource = typeof(TodoApp2Resource);
    }
}
