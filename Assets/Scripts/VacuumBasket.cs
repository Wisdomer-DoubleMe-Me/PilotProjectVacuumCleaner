using Microsoft.MixedReality.Toolkit.UI;
using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumBasket : MonoBehaviour
{
    [SerializeField]
    UIController uiController;
    [SerializeField]
    PartAssemblyController partAssembly;
    [SerializeField]
    Interactable button;

    private void Start()
    {
        partAssembly.OnSetPlacement += () =>
        {
            uiController.Comments = "Turn on the vacuumcleaner switch";
            button.IsInteractive = true;
        };
    }
}
