﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capture.Workflow.Core.Classes;
using Capture.Workflow.Core.Classes.Attributes;

namespace Capture.Workflow.Plugins.Views
{
    [Description("")]
    [PluginType(PluginType.View)]
    [DisplayName("Live view")]
    public class LiveView:BaseView
    {
        public override WorkFlowView CreateView()
        {
            WorkFlowView view = new WorkFlowView();
            view.Properties.Items.Add(new CustomProperty()
            {
                Name = "ViewTitle",
                PropertyType = CustomPropertyType.String
            });
            return view;
        }
    }
}
