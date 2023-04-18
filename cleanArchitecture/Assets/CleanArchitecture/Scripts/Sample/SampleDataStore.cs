using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace CleanArchitecture
{
    [Serializable]
    public class SampleDataStore : ScriptableObject, ISampleDataStore
    {
        [SerializeField] string sampleData;

        public string SampleData { set { sampleData = value; } get { return sampleData; } }
    }
}