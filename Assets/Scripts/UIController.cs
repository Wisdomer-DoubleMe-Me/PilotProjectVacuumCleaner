using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//UI ���� ��Ʈ�ѷ�
public class UIController : MonoBehaviour
{
    #region ���� & ������Ƽ
    
    //������Ƽ�� ������ �� �ְ�
    public string Comments
    {
        set
        {
            InformationComment?.Invoke(value);
        }
    }
    #endregion
    #region �̺�Ʈ
    public event System.Action<string> InformationComment;
    #endregion
}
