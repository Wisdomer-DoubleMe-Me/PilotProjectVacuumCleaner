using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//먼지 컨트롤러
public class DustController : MonoBehaviour
{
    #region Variables and Properties
    //콘텐츠 컨트롤러
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
