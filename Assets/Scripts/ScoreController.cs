using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//점수 숫자 기능 컨트롤러
public class ScoreController : MonoBehaviour
{
    #region 변수, 프로퍼티
    public int Score
    {
        set
        {
            ScoreChange?.Invoke(value);
        }
    }
    #endregion
    #region 이벤트
    public event System.Action<int> ScoreChange;
    #endregion
}
