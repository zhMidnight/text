using UnityEngine;

public class IntroductionManager : MonoBehaviour
{
    public GameObject introductionUI; // UI ���ڽ��ܳ�������
    public Transform player; // ��Ҷ���
    private bool inIntroduction = false; // �Ƿ����ڽ��ܳ�������

    private void OnTriggerEnter(Collider other)
    {
        // ��������ض�����������
        if (other.CompareTag("Player"))
        {
            inIntroduction = true;
            introductionUI.SetActive(true); // ��ʾUI��������
            Time.timeScale = 0f; // ��ͣ��Ϸʱ��
        }
    }

    private void Update()
    {
        if (inIntroduction)
        {
            // ���ո����������
            if (Input.GetKeyDown(KeyCode.T))
            {
                // �ر�UI��������
                introductionUI.SetActive(false);
                Time.timeScale = 1f; // �ָ���Ϸʱ��
                inIntroduction = false; // ���ܽ���
            }
        }
    }
}

