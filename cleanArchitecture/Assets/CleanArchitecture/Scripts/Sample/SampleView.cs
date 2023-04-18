using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CleanArchitecture
{
    public class SampleView : MonoBehaviour, ISampleView
    {
        [SerializeField] private Button sampleButton = default;
        public Button SampleButton => sampleButton;
    }
}

