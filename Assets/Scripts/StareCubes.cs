using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ť�� ���� - �������..?
public class StareCubes : MonoBehaviour
{
    #region ����, ������Ƽ
    //���ƾ� �� ������Ʈ
    [SerializeField]
    GameObject[] stareObjects;
    //���ƾ� �� ������Ʈ �˸�
    [SerializeField]
    DirectionalIndicator indicator;
    //�������� ��ȯ ��Ʈ�ѷ�
    [SerializeField]
    StageController stageController;
    //�ѷ��� ť�� ����
    public int StareIndex
    {
        set
        {
            if(value < stareObjects.Length)
            {
                for(int i = 0; i < stareObjects.Length; i++)
                {
                    stareObjects[i].SetActive(i == value);
                }
                indicator.DirectionalTarget = stareObjects[value].transform;
            }
            //ť�긦 �� ��������
            else
            {
                //�������� Ư�� �ܰ�� �ѱ��
                stageController.StageIndex = 1;
            }
        }
    }
    #endregion
}
