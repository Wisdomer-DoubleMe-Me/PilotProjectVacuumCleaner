using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//홀로 렌즈2 공간 스캔 적용 스크립트
public class SpatialAwarenessController : MonoBehaviour
{
    //공간 업데이트
    public int SpatialAwarenessIndex
    {
        set
        {
            SpatialAwarenessUpdate();
        }
    }
    //스캔 공간 정보 업데이트
    void SpatialAwarenessUpdate()
    {
        CoreServices.SpatialAwarenessSystem?.Update();
    }
    //
    private void OnDisable()
    {
        CoreServices.SpatialAwarenessSystem?.Dispose();
    }
}
