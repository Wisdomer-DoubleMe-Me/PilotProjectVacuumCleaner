using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ���� ��� ��Ʈ�ѷ�
public class ScoreController : MonoBehaviour
{
    #region ����, ������Ƽ
    public int Score
    {
        set
        {
            ScoreChange?.Invoke(value);
        }
    }
    #endregion
    #region �̺�Ʈ
    public event System.Action<int> ScoreChange;
    #endregion
}
