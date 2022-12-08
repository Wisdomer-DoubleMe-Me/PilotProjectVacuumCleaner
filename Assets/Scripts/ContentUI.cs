using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������ UI�߰�
public class ContentUI : MonoBehaviour
{
    #region ����
    //������ UI �ȳ� â
    [SerializeField]
    TMPro.TextMeshProUGUI information;
    //UI �̺�Ʈ ȣ���
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
