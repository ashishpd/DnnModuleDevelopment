using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dnn.Modules.HelloWorld.Dto;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using DotNetNuke.Entities.Modules;

namespace Dnn.Modules.HelloWorld
{
    public partial class View : PortalModuleBase
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!IsPostBack)
            {
                LoadTasks();
            }
        }

        protected void btnCreate_OnClick(object sender, EventArgs e)
        {
            var taskId = DataProvider.Instance().ExecuteScalar<int>("HelloWorld_CreateTask", txtTask.Text);
            LoadTasks();
        }

        private void LoadTasks()
        {
            var tasks = CBO.FillCollection<TaskDto>(
                    DataProvider.Instance().ExecuteReader("HelloWorld_GetTasks"));

            var data = string.Empty;
            foreach (var task in tasks)
            {
                data += "</Br>" + task.TaskId + " " + task.TaskName;
            }
            //lblTasks.Text = data;
            //lblTasks.Text = UserInfo.DisplayName.Substring(5,3);
            lblTasks.Text = UserInfo.DisplayName.ToUpper();
        }
    }
}