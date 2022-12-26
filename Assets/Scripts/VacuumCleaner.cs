using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� û�ұ�
public class VacuumCleaner : MonoBehaviour
{
    #region ����, ������Ƽ
    //���� ��Ʈ�ѷ�
    [SerializeField]
    DustController dustController;
    //���� ��� �̺�Ʈ
    [SerializeField]
    Collider vacuumcollider;
    //���� ��� ����Ʈ
    [SerializeField]
    ParticleSystem onEffect;
    //����, ���� ��ġ Ȯ��
    [SerializeField]
    Transform vacuumOrigin, dustOrigin;
    bool state;
    [SerializeField]
    Rigidbody vacuumCleanerRig;
    [SerializeField]
    SolverHandler headPos;
    //���� ����
    public bool State
    {
        get => state;
        set
        {
            state = !state;
            vacuumcollider.enabled = state;
            if (state)
            {
                onEffect.Play();
            }
            else
            {
                onEffect.Stop();
            }
        }
    }

    #endregion
    IEnumerator ResetPosition()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if (vacuumCleanerRig.velocity.magnitude > 0.5f)
            {
                vacuumCleanerRig.gameObject.transform.position = new Vector3(headPos.TransformTarget.position.x, headPos.TransformTarget.position.y, headPos.TransformTarget.position.z + 0.5f);
                vacuumCleanerRig.velocity = Vector3.zero;
            }
        }
    }

    #region ����Ƽ �Լ�
    private void OnEnable()
    {
        StartCoroutine(ResetPosition());
    }
    private void OnDisable()
    {
        StopAllCoroutines();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.transform.parent == dustOrigin)
        {
            other.GetComponent<Rigidbody>().velocity = (vacuumOrigin.position - other.transform.position).normalized;
            if (Vector3.Distance(other.transform.position, vacuumOrigin.position) < 0.1f)
            {
                dustController.DustAction = other.gameObject;
                other.gameObject.SetActive(false);
            }
        }
    }
    #endregion
}
