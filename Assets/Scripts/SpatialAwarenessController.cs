using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Ȧ�� ����2 ���� ��ĵ ���� ��ũ��Ʈ
public class SpatialAwarenessController : MonoBehaviour
{
    //���� �ʱ�ȭ ������Ƽ 0: ���� �ʱ�ȭ 1: ���� ������Ʈ
    public int SpatialAwarenessIndex
    {
        set
        {
            switch (value)
            {
                case 0:
                    SpatialAwarenessInit();
                    break;
                case 1:
                    SpatialAwarenessUpdate();
                    break;
                default:

                    break;
            }
        }
    }
    
    void SpatialAwarenessInit()
    {
        if (CoreServices.SpatialAwarenessSystem == null)
        {
            CoreServices.SpatialAwarenessSystem.Initialize();
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
