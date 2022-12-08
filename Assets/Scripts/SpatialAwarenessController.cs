using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ȧ�� ����2 ���� ��ĵ ���� ��ũ��Ʈ
public class SpatialAwarenessController : MonoBehaviour
{
    //���� ������Ʈ
    public int SpatialAwarenessIndex
    {
        set
        {
            SpatialAwarenessUpdate();
        }
    }
    //��ĵ ���� ���� ������Ʈ
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
