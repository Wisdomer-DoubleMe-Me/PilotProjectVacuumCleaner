using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ��Ʈ�ѷ�
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //������ ��Ʈ�ѷ�
    [SerializeField]
    StageController stageController;
    //�������� ��� ������Ʈ
    [SerializeField]
    GameObject[] stages;
    #endregion
    #region UnityFunction

    private void Start()
    {
        stageController.StageChange += DustOperation;
        stageController.StageIndex = 0;
    }
    #endregion
    #region Function
    //
    void DustOperation(int contentsIndex)
    {
        for(int i = 0; i < stages.Length; i++)
        {
            stages[i].gameObject.SetActive(i == contentsIndex);
        }
    }
    #endregion
}
