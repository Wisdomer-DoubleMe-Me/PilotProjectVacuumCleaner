using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//����
public class Dust : MonoBehaviour
{
    #region ����
    //
    [SerializeField]
    SolverHandler headSolver;
    //
    [SerializeField]
    ScoreController scoreController;

    Rigidbody rigidbody;
    #endregion
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        
        StartCoroutine(CheckForGround());
        Vector3 referencePosition = headSolver.TransformTarget.position;
        transform.position = new Vector3(referencePosition.x + Random.Range(-1f, 1f), referencePosition.y + 0.2f, referencePosition.z + Random.Range(-1f, 1f));
    }
    
    //
    private void OnDisable()
    {
        scoreController.Score++;
        StopAllCoroutines();
    }
    //���� ������ Ȯ���ϱ�
    IEnumerator CheckForGround()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if (rigidbody.velocity.magnitude > 0.5f)
            {
                rigidbody.velocity = Vector3.zero;
                Vector3 referencePosition = headSolver.TransformTarget.position;
                transform.position = new Vector3(referencePosition.x + Random.Range(-1f, 1f), referencePosition.y + 0.2f, referencePosition.z + Random.Range(-1f, 1f));
            }
        }
    }

}
