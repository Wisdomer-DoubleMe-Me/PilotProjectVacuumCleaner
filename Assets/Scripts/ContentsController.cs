using Microsoft.MixedReality.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������ ���� ��Ʈ�ѷ�
public class ContentsController : MonoBehaviour
{
    //����, ������Ƽ
    #region Variables and Properties
    //������ ���� �ε��� ����
    [SerializeField]
    int _contentsIndex;
    //������ �ε���
    public int ContentsIndex
    {
        get => _contentsIndex;
        set
        {
            _contentsIndex = value;
            if(CoreServices.SpatialAwarenessSystem != null)
            {
                ContentsOperation?.Invoke(_contentsIndex);
            }
            else
            {
                ErrorUIOperation?.Invoke("Please, Initialize Spatial Awareness!");
            }
        }
    }
    //���� �޽��� ���⿡ �α�
    public string ErrorComment
    {
        set
        {
            ErrorUIOperation?.Invoke(value);
        }
    }
    #endregion
    #region Event
    //�̺�Ʈ �Լ� : ������ ����
    public event Action<int> ContentsOperation;
    //�̺�Ʈ �Լ� : ���� �α� �����
    public event Action<string> ErrorUIOperation;
    #endregion
}
