using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
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
    [SerializeField]
    VacuumCleaner cleaner;
    [SerializeField]
    DirectionalIndicator directionalIndicator;
    private void Start()
    {
        partAssembly.OnSetPlacement += () =>
        {
            uiController.Comments = "Turn on the vacuumcleaner switch";
            partAssembly.gameObject.GetComponent<Collider>().enabled = false;
            GetComponent<Collider>().enabled = false;
            button.OnClick.AddListener(() =>
            {
                cleaner.State = true;
            });
            DestroyImmediate(partAssembly.gameObject.GetComponent<Rigidbody>());
            directionalIndicator.gameObject.SetActive(false);
            partAssembly.enabled = false;
        };
    }
}
