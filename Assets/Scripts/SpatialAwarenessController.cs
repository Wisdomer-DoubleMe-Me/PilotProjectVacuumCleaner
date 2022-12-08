using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//홀로 렌즈2 공간 스캔 적용 스크립트
public class SpatialAwarenessController : MonoBehaviour
{
    //공간 초기화 프로퍼티 공간 업데이트
    public int SpatialAwarenessIndex
    {
        set
        {
            SpatialAwarenessUpdate();
        }
    }
    
    
    void SpatialAwarenessUpdate()
    {
        CoreServices.SpatialAwarenessSystem?.Update();
    }


    private void OnDisable()
    {
        CoreServices.SpatialAwarenessSystem?.Dispose();
    }
}
