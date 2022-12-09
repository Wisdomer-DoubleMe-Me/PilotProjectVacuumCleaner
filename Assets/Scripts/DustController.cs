using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
//먼지 컨트롤러
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //콘텐츠 컨트롤러
    [SerializeField]
    StageController stageController;
    //스테이지 담당 오브젝트
    [SerializeField]
    GameObject[] stages;
    //먼지 탐지 확인
    [SerializeField]
    Transform dustOrigin;
    //먼지 오브젝트들
    [SerializeField]
    List<GameObject> dustObject = new List<GameObject> ();
    
    
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

    public void ContentsReset()
    {
        int buildIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(buildIndex);
    }
    public void ContentsExit()
    {
        Application.Quit();
    }
    #endregion
}
