using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanArchitecture
{
    public interface ISampleDataStore : IDataStore
    {
        string SampleData { set; get; }
    }
}