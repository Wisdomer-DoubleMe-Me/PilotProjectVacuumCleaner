using MRTK.Tutorials.GettingStarted;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceIt : MonoBehaviour
{
    [SerializeField]
    UIController uiController;
    [SerializeField]
    PartAssemblyController partAssembly, vacuumAssembly;
    private void Start()
    {
        partAssembly.OnSetPlacement += () =>
        {
            uiController.Comments = "Find the vacuumbasket and place it vacuumcleaner";
            GetComponent<Collider>().enabled = false;
            partAssembly.gameObject.GetComponent<Collider>().enabled = false;
            DestroyImmediate(partAssembly.GetComponent<Rigidbody>());
            vacuumAssembly.enabled = true;
            partAssembly.enabled = false;
        };
    }
}
