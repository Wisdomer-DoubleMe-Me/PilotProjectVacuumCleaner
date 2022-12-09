using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceIt : MonoBehaviour
{
    [SerializeField]
    UIController uiController;
    [SerializeField]
    PartAssemblyController partAssembly;
    private void Start()
    {
        partAssembly.OnSetPlacement += () =>
        {
            uiController.Comments = "Find the vacuumbasket and place it vacuumcleaner";
        };
    }
}
