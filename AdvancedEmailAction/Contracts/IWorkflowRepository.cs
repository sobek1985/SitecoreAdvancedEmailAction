﻿using System.Collections.Generic;
using MikeRobbins.AdvancedEmailAction.Entities;
using Sitecore.Collections;
using Sitecore.Data.Items;
using Sitecore.Workflows;

namespace MikeRobbins.AdvancedEmailAction.Contracts
{
    public interface IWorkflowRepository
    {
        List<WorkflowHistoryItem> GetWorkflowHistory(Item itemInWorkflow);
        WorkflowHistoryItem GetWorkflowHistoryForItem(Item item, StringDictionary comments, Item emailAction);
        string GetItemWorkflowName(Item workflowItem);
        WorkflowState GetWorkflowStateForItem(Item item, Item emailAction);
    }
}