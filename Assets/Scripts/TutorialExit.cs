using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ʃ�丮�� ����
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
