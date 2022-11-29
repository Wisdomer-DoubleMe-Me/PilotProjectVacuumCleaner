using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//UI 관련 컨트롤러
public class UIController : MonoBehaviour
{
    #region 변수 & 프로퍼티
    //TMPro UI
    [SerializeField]
    TMPro.TextMeshProUGUI information;
    
    //싱글턴
    static UIController _instance;
    public static UIController Instance
    {
        get => _instance;
    }
    //스테이지 몇번째인지 알려주는 인덱스
    [SerializeField]
    int _stageIndex;
    //프로퍼티로 변경할 수 있게
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
    #region 함수

    private void Awake()
    {
        //싱글턴 지정
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
