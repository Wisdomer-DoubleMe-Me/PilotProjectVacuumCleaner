using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI에 점수 표시하는 스크립트
public class ScoreUI : MonoBehaviour
{
    //점수 컨트롤러
    [SerializeField]
    ScoreController scoreController;
    //
    [SerializeField]
    UIController uiController;
    //점수 보이는 UI
    [SerializeField]
    TMPro.TextMeshProUGUI scoreExplain, scoreInfo;

    
    void Awake()
    {
        //이벤트 함수 설정
        scoreController.ScoreChange += (score) =>
        {
            if (score > 0)
            {
                uiController.Comments = "Clean the Dust";
            }
            scoreExplain.enabled = scoreInfo.enabled = score > 0;
            scoreInfo.text = score.ToString();
        };
    }
    private void OnEnable()
    {
        scoreController.Score = 0;
    }
}
