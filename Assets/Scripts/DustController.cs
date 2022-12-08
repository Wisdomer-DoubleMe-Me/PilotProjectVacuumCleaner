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
    //���� Ž�� Ȯ��
    [SerializeField]
    Transform dustOrigin;
    //���� ������Ʈ��
    [SerializeField]
    List<GameObject> dustObject = new List<GameObject> ();
    //
    [SerializeField]
    ScoreController scoreController;
    
    public GameObject DustAction
    {
        set
        {
            GameObject dust = dustObject.Find(dust => dust == value);
            if(dust != null)
            {
                StartCoroutine(DustEnable(dust));
            }
        }
    }

    #endregion
    #region UnityFunction

    private void Awake()
    {
        stageController.StageChange += (stageIndex) =>
        {
            for (int i = 0; i < stages.Length; i++)
            {
                stages[i].gameObject.SetActive(i == stageIndex);
            }
        };
        stageController.StageIndex = 0;
        scoreController.ScoreChange += (score) =>
        {
            //���� 10�� �������...?
            if(score % 10 == 0)
            {

            }
        };
    }
    private void OnEnable()
    {
        dustObject.Clear();
        for(int i = 0; i< dustOrigin.childCount; i++)
        {
            dustObject.Add(dustOrigin.GetChild(i).gameObject);
        }
    }
    #endregion
    #region Function
    IEnumerator DustEnable(GameObject dust)
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 5f));
        dust.SetActive(true);
        yield break;
    }
    #endregion
}
