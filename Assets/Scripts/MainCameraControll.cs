using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraControll : MonoBehaviour
{
    //要看向的目标角色 
    public Transform target;
    //摄像机相对目标角色在x,y,z上的偏移量
    public Vector3 offsetPos;
    //看向位置的y的高度
    public float bodyHeight;
    //偏移速度
    public float moveSpeed;
    //旋转速度
    public float rotateSpeed;
    //相机的目标坐标 
    private Vector3 targetPos;
    //相机要看向的方向向量
    private Quaternion targetRotation;


    // Update is called once per frame
    void Update()
    {
        //判断target是否存在
        if (target == null) return;
        //获取相机的位置  
        targetPos = target.position + target.forward * offsetPos.z + target.up * offsetPos.y + target.right * offsetPos.x;
        //插值运算  
        this.transform.position = Vector3.Lerp(this.transform.position,targetPos,moveSpeed*Time.deltaTime);
        //获取方向向量 
        targetRotation = Quaternion.LookRotation(target.position+target.up*bodyHeight-this.transform.position);
        //插值运算 
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,targetRotation,rotateSpeed*Time.deltaTime);
    }
}
