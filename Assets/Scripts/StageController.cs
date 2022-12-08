using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//스테이지 전환 컨트롤러
public class StageController : MonoBehaviour
{
    int stageIndex;
    public int StageIndex
    {
        set
        {
            stageIndex = value;
            StageChange?.Invoke(stageIndex);
        }
    }

    public event System.Action<int> StageChange;
}
