using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�������� Ȱ��ȭ ������Ʈ��..
public class StageObject : MonoBehaviour
{
    #region ����
    [SerializeField]
    string comments;
    [SerializeField]
    UIController uiController;
    #endregion
    #region ����Ƽ �Լ�
    private void OnEnable()
    {
        uiController.Comments = comments;
    }
    #endregion
}
