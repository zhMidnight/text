using UnityEngine;

public class IntroductionManager : MonoBehaviour
{
    public GameObject introductionUI; // UI 用于介绍场景内容
    public Transform player; // 玩家对象
    private bool inIntroduction = false; // 是否正在介绍场景内容

    private void OnTriggerEnter(Collider other)
    {
        // 如果进入特定区域的是玩家
        if (other.CompareTag("Player"))
        {
            inIntroduction = true;
            introductionUI.SetActive(true); // 显示UI介绍内容
            Time.timeScale = 0f; // 暂停游戏时间
        }
    }

    private void Update()
    {
        if (inIntroduction)
        {
            // 按空格键结束介绍
            if (Input.GetKeyDown(KeyCode.T))
            {
                // 关闭UI介绍内容
                introductionUI.SetActive(false);
                Time.timeScale = 1f; // 恢复游戏时间
                inIntroduction = false; // 介绍结束
            }
        }
    }
}

