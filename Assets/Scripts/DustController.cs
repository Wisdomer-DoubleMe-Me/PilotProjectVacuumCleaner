using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� ��Ʈ�ѷ�
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //������ ��Ʈ�ѷ�
    [SerializeField]
    ContentsController contentsController;
    #endregion
    #region UnityFunction

    private void Start()
    {
        contentsController.ContentsOperation += DustOperation;
    }
    #endregion
    #region Function
    //
    void DustOperation(int contentsIndex)
    {
        switch (contentsIndex)
        {
            case 0:

                break;
            case 1:

                break;
        }
    }
    #endregion
}
