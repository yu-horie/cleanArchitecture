using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CleanArchitecture
{
    public interface ISampleRepository : IRepository
    {
        string SampleData { get; set; }
    }
}