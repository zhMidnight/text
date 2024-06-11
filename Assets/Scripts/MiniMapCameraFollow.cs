using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCameraFollow : MonoBehaviour
{
    public Transform target; // ��Ϸ����� Transform ���

    void Update()
    {
        if (target != null)
        {
            // �� MiniMapCamera ��λ����Ϊ����Ϸ������ͬ�����ǽ� y ���������һ�����ʵĸ߶�
            transform.position = new Vector3(target.position.x, 30f, target.position.z);

            // MiniMapCamera ������Ϸ����ĳ�����ת
            transform.rotation = Quaternion.Euler(90f, target.eulerAngles.y, 0f);
        }
    }
}
