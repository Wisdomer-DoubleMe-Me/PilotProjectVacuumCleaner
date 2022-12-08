using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI�� ���� ǥ���ϴ� ��ũ��Ʈ
public class ScoreUI : MonoBehaviour
{
    //���� ��Ʈ�ѷ�
    [SerializeField]
    ScoreController scoreController;
    //���� ���̴� UI
    [SerializeField]
    TMPro.TextMeshProUGUI scoreExplain, scoreInfo;

    
    void Awake()
    {
        //�̺�Ʈ �Լ� ����
        scoreController.ScoreChange += (score) =>
        {
            scoreExplain.enabled = scoreInfo.enabled = score > 0;
            scoreInfo.text = score.ToString();
        };
    }
    private void OnEnable()
    {
        scoreController.Score = 0;
    }
}
