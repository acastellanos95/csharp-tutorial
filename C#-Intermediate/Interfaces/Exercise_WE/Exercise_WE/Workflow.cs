﻿using System.Collections.Generic;

namespace Exercise_WE
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;
        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public Workflow(IList<IActivity> listOfActivities)
        {
            _activities = listOfActivities;
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities) activity.Execute();
        }
    }
}
