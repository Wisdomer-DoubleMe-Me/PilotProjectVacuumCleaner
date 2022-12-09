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
    #region ����Ƽ �Լ�
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
