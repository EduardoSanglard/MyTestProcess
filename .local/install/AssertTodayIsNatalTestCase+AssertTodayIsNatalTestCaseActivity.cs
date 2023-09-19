using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;

namespace MyTestProcess_Tests
{
    public class AssertTodayIsNatalTestCaseActivity : System.Activities.Activity
    {
        public AssertTodayIsNatalTestCaseActivity()
        {
            this.Implementation = () =>
            {
                return new AssertTodayIsNatalTestCaseActivityChild()
                {};
            };
        }
    }

    internal class AssertTodayIsNatalTestCaseActivityChild : CodeActivity
    {
        public AssertTodayIsNatalTestCaseActivityChild()
        {
            DisplayName = "AssertTodayIsNatalTestCase";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new MyTestProcess.AssertTodayIsNatalTestCase();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "AssertTodayIsNatalTestCase.cs"});
                }
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "AssertTodayIsNatalTestCase.cs", Exception = exception});
                }
            });
        }
    }
}