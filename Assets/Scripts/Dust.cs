using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//먼지
public class Dust : MonoBehaviour
{
    #region 변수
    //
    [SerializeField]
    SolverHandler headSolver;
    //
    [SerializeField]
    ScoreController scoreController;

    Rigidbody rigidbody;
    #endregion
    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody>();
        StartCoroutine(CheckForGround());
        Vector3 referencePosition = headSolver.TransformTarget.position;
        transform.position = new Vector3(referencePosition.x + Random.Range(-1f, 1f), referencePosition.y + 0.2f, referencePosition.z + Random.Range(-1f, 1f));
    }
    
    //
    private void OnDisable()
    {
        scoreController.Score++;
    }
    //멈춘 것인지 확인하기
    IEnumerator CheckForGround()
    {
        yield return new WaitForSeconds(2);
        if(rigidbody.velocity.magnitude > 0.5f)
        {
            yield return CheckForGround();
        }
        yield break;
    }

}
