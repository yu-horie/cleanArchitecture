using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanArchitecture
{
    public class SampleRepository : ISampleRepository
    {
        readonly ISampleDataStore dataStore;

        public SampleRepository(ISampleDataStore dataStore)
        {
            this.dataStore = dataStore;
        }

        public string SampleData
        {
            get => dataStore.SampleData;
            set => dataStore.SampleData = value;
        }
    }
}
