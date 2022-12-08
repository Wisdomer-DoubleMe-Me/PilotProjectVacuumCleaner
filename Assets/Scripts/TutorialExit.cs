using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//튜토리얼 종료
public class TutorialExit : MonoBehaviour
{
    [SerializeField]
    int waitTime;
    private void OnEnable()
    {
        StartCoroutine(ExitTutorial());
    }

    IEnumerator ExitTutorial()
    {
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<StageController>().StageIndex = 2;
        yield break;
    }
}
