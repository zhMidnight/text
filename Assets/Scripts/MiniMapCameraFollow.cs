using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCameraFollow : MonoBehaviour
{
    public Transform target; // 游戏人物的 Transform 组件

    void Update()
    {
        if (target != null)
        {
            // 将 MiniMapCamera 的位置设为与游戏人物相同，但是将 y 坐标调整到一个合适的高度
            transform.position = new Vector3(target.position.x, 30f, target.position.z);

            // MiniMapCamera 根据游戏人物的朝向旋转
            transform.rotation = Quaternion.Euler(90f, target.eulerAngles.y, 0f);
        }
    }
}
