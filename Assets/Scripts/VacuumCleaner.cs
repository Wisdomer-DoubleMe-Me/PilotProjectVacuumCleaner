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
    //���� ��� �Ҹ�
    [SerializeField]
    AudioSource vacuumSound;

    [SerializeField]
    Transform vacuumOrigin, dustOrigin;
    //���� ����
    public bool State
    {
        set
        {
            vacuumcollider.enabled = value;
            if (value)
            {
                onEffect.Play();
                vacuumSound.Play();
            }
            else
            {
                onEffect.Stop();
                vacuumSound.Stop();
            }
        }
    }


    #endregion
    #region ����Ƽ �Լ�
    private void OnTriggerStay(Collider other)
    {
        if(other.transform.parent == dustOrigin)
        {
            other.GetComponent<Rigidbody>().velocity = (other.transform.position - vacuumOrigin.position).normalized;
            if(Vector3.Distance(other.transform.position, vacuumOrigin.position) < 0.01f)
            {
                other.gameObject.SetActive(false);
            }
        }
    }
    #endregion
}
