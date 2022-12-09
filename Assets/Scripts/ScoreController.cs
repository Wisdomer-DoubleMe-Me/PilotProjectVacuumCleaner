using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ���� ��� ��Ʈ�ѷ�
public class ScoreController : MonoBehaviour
{
    #region ����, ������Ƽ
    int score;
    public int Score
    {
        get => score;
        set
        {
            score = value;
            ScoreChange?.Invoke(score);
        }
    }
    #endregion
    #region �̺�Ʈ
    public event System.Action<int> ScoreChange;
    #endregion
}
