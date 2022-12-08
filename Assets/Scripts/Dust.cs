using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//먼지
public class Dust : MonoBehaviour
{
    [SerializeField]
    SolverHandler headsolver;
    [SerializeField]
    ScoreController scoreController;
    private void OnEnable()
    {
        MovePosition();
        StartCoroutine(CheckForGround());
    }
    /// <summary>
    /// 위치 재조정 함수
    /// </summary>
    private void MovePosition()
    {
        var targetTransformPos = headsolver.TransformTarget.position;
        var randomX = targetTransformPos.x + Random.Range(-1f, 1f);
        var yOffset = targetTransformPos.y + 0.5f;
        var randomZ = targetTransformPos.z + Random.Range(-1f, 1f);

        transform.position = new Vector3(randomX, yOffset, randomZ);
    }

    private void OnDisable()
    {
        scoreController.Score++;
    }
    //
    IEnumerator CheckForGround()
    {
        yield return new WaitForSeconds(2);

        OnEnable();
        yield return CheckForGround();
    }

}
