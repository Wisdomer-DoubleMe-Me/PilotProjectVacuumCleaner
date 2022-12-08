using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�������� ��ȯ ��Ʈ�ѷ�
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
