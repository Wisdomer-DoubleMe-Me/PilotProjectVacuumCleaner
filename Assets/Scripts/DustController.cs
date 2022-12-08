using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//먼지 컨트롤러
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //콘텐츠 컨트롤러
    [SerializeField]
    StageController stageController;
    [SerializeField]
    GameObject[] stages;
    #endregion
    #region UnityFunction

    private void Start()
    {
        stageController.StageChange += DustOperation;
    }
    #endregion
    #region Function
    //
    void DustOperation(int contentsIndex)
    {
        for(int i = 0; i < stages.Length; i++)
        {
            stages[i].gameObject.SetActive(i == contentsIndex);
        }
    }
    #endregion
}
