﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Planner User.
    /// </summary>
    public partial class PlannerUser : PlannerDelta
    {
    
        ///<summary>
        /// The PlannerUser constructor
        ///</summary>
        public PlannerUser()
        {
            this.ODataType = "microsoft.graph.plannerUser";
        }

        /// <summary>
        /// Gets or sets favorite plan references.
        /// A collection containing the references to the plans that the user has marked as favorites.
        /// </summary>
        [JsonPropertyName("favoritePlanReferences")]
        public PlannerFavoritePlanReferenceCollection FavoritePlanReferences { get; set; }
    
        /// <summary>
        /// Gets or sets recent plan references.
        /// A collection containing references to the plans that were viewed recently by the user in apps that support recent plans.
        /// </summary>
        [JsonPropertyName("recentPlanReferences")]
        public PlannerRecentPlanReferenceCollection RecentPlanReferences { get; set; }
    
        /// <summary>
        /// Gets or sets all.
        /// </summary>
        [JsonPropertyName("all")]
        public IPlannerUserAllCollectionPage All { get; set; }

        /// <summary>
        /// Gets or sets allNextLink.
        /// </summary>
        [JsonPropertyName("all@odata.nextLink")]
        public string AllNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets favorite plans.
        /// Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.
        /// </summary>
        [JsonPropertyName("favoritePlans")]
        public IPlannerUserFavoritePlansCollectionWithReferencesPage FavoritePlans { get; set; }

        /// <summary>
        /// Gets or sets favoritePlansNextLink.
        /// </summary>
        [JsonPropertyName("favoritePlans@odata.nextLink")]
        public string FavoritePlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonPropertyName("plans")]
        public IPlannerUserPlansCollectionPage Plans { get; set; }

        /// <summary>
        /// Gets or sets plansNextLink.
        /// </summary>
        [JsonPropertyName("plans@odata.nextLink")]
        public string PlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets recent plans.
        /// Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.
        /// </summary>
        [JsonPropertyName("recentPlans")]
        public IPlannerUserRecentPlansCollectionWithReferencesPage RecentPlans { get; set; }

        /// <summary>
        /// Gets or sets recentPlansNextLink.
        /// </summary>
        [JsonPropertyName("recentPlans@odata.nextLink")]
        public string RecentPlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets roster plans.
        /// Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.
        /// </summary>
        [JsonPropertyName("rosterPlans")]
        public IPlannerUserRosterPlansCollectionWithReferencesPage RosterPlans { get; set; }

        /// <summary>
        /// Gets or sets rosterPlansNextLink.
        /// </summary>
        [JsonPropertyName("rosterPlans@odata.nextLink")]
        public string RosterPlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns the plannerTasks assigned to the user.
        /// </summary>
        [JsonPropertyName("tasks")]
        public IPlannerUserTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        public string TasksNextLink { get; set; }
    
    }
}

