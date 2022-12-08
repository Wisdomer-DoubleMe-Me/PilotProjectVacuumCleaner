using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [SerializeField]
    List<Dust> dusts = new List<Dust>();


    public Dust dustAction
    {
        set
        {

        }
    }
    #endregion
    #region UnityFunction

    private void Awake()
    {
        stageController.StageChange += DustOperation;
        stageController.StageIndex = 0;
    }
    private void OnEnable()
    {
        dusts = FindObjectsOfType<Dust>().ToList();
    }
    #endregion
    #region Function
    //�������� ������Ʈ ��ȯ �Լ�
    void DustOperation(int contentsIndex)
    {
        for(int i = 0; i < stages.Length; i++)
        {
            stages[i].gameObject.SetActive(i == contentsIndex);
        }
    }

    #endregion
}
