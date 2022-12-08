using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//큐브 응시 - 노려보기..?
public class StareCubes : MonoBehaviour
{
    #region 변수, 프로퍼티
    //보아야 할 오브젝트
    [SerializeField]
    GameObject[] stareObjects;
    //보아야 할 오브젝트 알림
    [SerializeField]
    DirectionalIndicator indicator;
    //스테이지 변환 컨트롤러
    [SerializeField]
    StageController stageController;
    //둘러본 큐브 숫자
    public int StareIndex
    {
        set
        {
            if(value < stareObjects.Length)
            {
                for(int i = 0; i < stareObjects.Length; i++)
                {
                    stareObjects[i].SetActive(i == value);
                }
                indicator.DirectionalTarget = stareObjects[value].transform;
            }
            //큐브를 다 보았으면
            else
            {
                //스테이지 특정 단계로 넘기기
                stageController.StageIndex = 1;
            }
        }
    }
    #endregion
}
