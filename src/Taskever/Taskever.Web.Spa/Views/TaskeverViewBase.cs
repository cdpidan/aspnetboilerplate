﻿using Abp.Web.Mvc.Views;

namespace Taskever.Web.Views
{
    public abstract class TaskeverViewBase : TaskeverViewBase<dynamic>
    {

    }

    public abstract class TaskeverViewBase<TModel> : AbpWebViewPage<TModel>
    {
        public TaskeverViewBase()
        {
            LocalizationSourceName = "Taskever";
        }
    }
}