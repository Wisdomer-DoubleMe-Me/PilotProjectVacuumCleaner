using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//콘텐츠 UI추가
public class ContentUI : MonoBehaviour
{
    #region 변수
    //콘텐츠 UI 안내 창
    [SerializeField]
    TMPro.TextMeshProUGUI information;
    //UI 이벤트 호출용
    [SerializeField]
    UIController controller;
    #endregion
    #region 유니티 함수
    // Start is called before the first frame update
    void Start()
    {
        controller.InformationComment += (comment) =>
        {
            information.text = comment;
        };
    }
    #endregion


}
