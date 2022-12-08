using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//스테이지 전환 컨트롤러
public class StageController : MonoBehaviour
{
    //스테이지 순서
    int stageIndex;
    //스테이지 프로퍼티
    public int StageIndex
    {
        set
        {
            stageIndex = value;
            StageChange?.Invoke(stageIndex);
        }
    }
    //스테이지 전환 이벤트
    public event System.Action<int> StageChange;
}
