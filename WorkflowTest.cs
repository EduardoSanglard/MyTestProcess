using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;

// NOTICE: The Coded Automations feature is available as a preview feature and APIs may be subject to change. 
//         No warranty or technical support is provided for this preview feature.
//         Missing features or encountering bugs? Please click the feedback button in the top-right corner and let us know!
// Please delete these comments after you've read and acknowledged them. For more information, please visit the documentation over at https://docs.uipath.com/studio/lang-en/v2023.10/docs/coded-automations-introduction.
namespace MyTestProcess
{
    public class WorkflowTest : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            // To start using services, use IntelliSense (CTRL + Space) to discover the available services:
            // e.g. system.GetAsset(...)
            Log("This is a coded workflow insied UiPath !");
        }
    }
}