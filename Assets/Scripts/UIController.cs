using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//UI 관련 컨트롤러
public class UIController : MonoBehaviour
{
    #region 변수 & 프로퍼티
    
    //프로퍼티로 변경할 수 있게
    public string Comments
    {
        set
        {
            InformationComment?.Invoke(value);
        }
    }
    #endregion
    #region 이벤트
    public event System.Action<string> InformationComment;
    #endregion
}
