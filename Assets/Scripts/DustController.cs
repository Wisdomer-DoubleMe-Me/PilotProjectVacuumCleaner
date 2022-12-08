using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//먼지 컨트롤러
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //콘텐츠 컨트롤러
    [SerializeField]
    StageController stageController;
    //스테이지 담당 오브젝트
    [SerializeField]
    GameObject[] stages;
    [SerializeField]
    List<Dust> dusts = new List<Dust>();


    public Dust dustAction
    {
        set
        {

        }
    }
    #endregion
    #region UnityFunction

    private void Awake()
    {
        stageController.StageChange += DustOperation;
        stageController.StageIndex = 0;
    }
    private void OnEnable()
    {
        dusts = FindObjectsOfType<Dust>().ToList();
    }
    #endregion
    #region Function
    //스테이지 오브젝트 변환 함수
    void DustOperation(int contentsIndex)
    {
        for(int i = 0; i < stages.Length; i++)
        {
            stages[i].gameObject.SetActive(i == contentsIndex);
        }
    }

    #endregion
}
