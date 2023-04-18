using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CleanArchitecture
{
    public interface ISampleView : IView
    {
        Button SampleButton { get; }
    }
}