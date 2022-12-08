using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//스테이지 활성화 오브젝트들..
public class StageObject : MonoBehaviour
{
    #region 변수
    [SerializeField]
    string comments;
    [SerializeField]
    UIController uiController;
    #endregion
    #region 유니티 함수
    private void OnEnable()
    {
        uiController.Comments = comments;
    }
    #endregion
}
