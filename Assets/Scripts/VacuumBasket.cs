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
    [SerializeField]
    SolverHandler headPos;
    [SerializeField]
    Rigidbody rig;
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
                uiController.Comments = "Clean the Dust";
            });
            DestroyImmediate(partAssembly.gameObject.GetComponent<Rigidbody>());
            directionalIndicator.gameObject.SetActive(false);
            partAssembly.enabled = false;
        };
    }
    private void OnEnable()
    {
        StartCoroutine(ResetPosition());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    IEnumerator ResetPosition()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if (rig.velocity.magnitude > 0.5f)
            {
                rig.velocity = Vector3.zero;
                rig.gameObject.transform.position = new Vector3(headPos.TransformTarget.position.x + Random.Range(-1f, 1f), headPos.TransformTarget.position.y + 0.3f, headPos.TransformTarget.position.z + Random.Range(-1f, 1f));
            }
        }
    }
}
