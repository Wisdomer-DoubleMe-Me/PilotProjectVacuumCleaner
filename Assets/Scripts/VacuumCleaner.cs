using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//진공 청소기
public class VacuumCleaner : MonoBehaviour
{
    #region 변수, 프로퍼티
    //먼지 컨트롤러
    [SerializeField]
    DustController dustController;
    //먼지 흡수 이벤트
    [SerializeField]
    Collider vacuumcollider;
    //먼지 흡수 이펙트
    [SerializeField]
    ParticleSystem onEffect;
    //진공, 먼지 위치 확인
    [SerializeField]
    Transform vacuumOrigin, dustOrigin;

    bool state;
    //켜진 상태
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
    #region 유니티 함수
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
