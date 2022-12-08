using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//진공 청소기
public class VacuumCleaner : MonoBehaviour
{

    #region 변수, 프로퍼티
    [SerializeField]
    Collider vacuumcollider;
    [SerializeField]
    ParticleSystem onEffect;
    [SerializeField]
    AudioSource vacuumSound;
    [SerializeField]
    Transform vacuumOrigin, dustOrigin;

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
    #region 유니티 함수
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
