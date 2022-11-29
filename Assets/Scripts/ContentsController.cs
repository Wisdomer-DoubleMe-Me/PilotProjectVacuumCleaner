using Microsoft.MixedReality.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//콘텐츠 전반 컨트롤러
public class ContentsController : MonoBehaviour
{
    //변수, 프로퍼티
    #region Variables and Properties
    //콘텐츠 진행 인덱스 숫자
    [SerializeField]
    int _contentsIndex;
    //콘텐츠 인덱스
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
    //에러 메시지 여기에 두기
    public string ErrorComment
    {
        set
        {
            ErrorUIOperation?.Invoke(value);
        }
    }
    #endregion
    #region Event
    //이벤트 함수 : 콘텐츠 진행
    public event Action<int> ContentsOperation;
    //이벤트 함수 : 에러 로그 띄우기용
    public event Action<string> ErrorUIOperation;
    #endregion
}
