using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public Camera MainCamra;
    public Camera FrontCamera;
    //���ˮƽƫ����
    private float MouseX;
    //��ȡˮƽ����ֱ������ƫ���� 
    private float Horizontal;
    private float Vertical;
    //�ƶ��ٶ�
    private float moveSpeed;
    //�ƶ���position
    private Vector3 movePosition;
    //ֻ��Ҫ������ҵ���ת�ǶȾͿ�����
    private Animator Animator;
    void Start()
    {
        MainCamra.gameObject.SetActive(true);
        FrontCamera.gameObject.SetActive(false);
        Animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = 2;
        if(Input.GetKey("left shift"))
        {
            moveSpeed = 5;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            MouseX = Input.GetAxis("Mouse X");
            this.transform.Rotate(0, MouseX, 0);

            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            Animator.SetFloat("X", Horizontal);
            Animator.SetFloat("Y", Vertical);
            Animator.SetFloat("Speed", moveSpeed);
            movePosition = this.transform.position + this.transform.forward * Vertical + this.transform.right * Horizontal;
            this.transform.position = Vector3.Lerp(this.transform.position, movePosition, moveSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Animator.SetTrigger("Jump");
            }

            if (Input.GetMouseButtonDown(0))
            {
                MainCamra.gameObject.SetActive(false);
                FrontCamera.gameObject.SetActive(true);
            }
            if (Input.GetMouseButtonDown(1))
            {
                MainCamra.gameObject.SetActive(true);
                FrontCamera.gameObject.SetActive(false);
            }
        }

    }
}
