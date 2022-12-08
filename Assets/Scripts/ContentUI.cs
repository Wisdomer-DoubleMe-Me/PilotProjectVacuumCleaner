using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������ UI�߰�
public class ContentUI : MonoBehaviour
{
    #region ����
    [SerializeField]
    TMPro.TextMeshProUGUI information;
    [SerializeField]
    UIController controller;
    #endregion
    #region ����Ƽ �Լ�
    // Start is called before the first frame update
    void Start()
    {
        controller.InformationComment += (comment) =>
        {
            information.text = comment;
        };
    }
    #endregion


}
