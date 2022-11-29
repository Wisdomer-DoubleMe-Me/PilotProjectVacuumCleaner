using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//UI ���� ��Ʈ�ѷ�
public class UIController : MonoBehaviour
{
    #region ���� & ������Ƽ
    //TMPro UI
    [SerializeField]
    TMPro.TextMeshProUGUI information;
    
    //�̱���
    static UIController _instance;
    public static UIController Instance
    {
        get => _instance;
    }
    //�������� ���°���� �˷��ִ� �ε���
    [SerializeField]
    int _stageIndex;
    //������Ƽ�� ������ �� �ְ�
    public int StageIndex
    {
        set
        {
            _stageIndex = value;
            string comment = _stageIndex switch
            {
                0=> "Flip Hand",
                1=> "Click ContentsInitialize Button",
                2=> "Find Vacuum Cleaner",
                3=> "Clean the Dust",
                4=> "Place Object",
                5=> "Complete",
                _=>"Contents Reset Require!"
            };
            information.text = comment;
        }
    }
    #endregion
    #region �Լ�

    private void Awake()
    {
        //�̱��� ����
        if(_instance == null)
        {
            _instance = this;
        }
    }

    private void OnValidate()
    {
        StageIndex = _stageIndex;
        print(information.text);
    }

    #endregion
}
