using UnityEngine;
using UnityEngine.UI;

public class RoamingSceneManager : MonoBehaviour
{
    public Image avatarImage;
    public Text playerNameText;

    public Sprite[] avatarSprites; // 头像库

    void Start()
    {
        // 从PlayerPrefs中获取玩家姓名
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;

        // 从头像库中随机选择一个头像
        int randomIndex = Random.Range(0, avatarSprites.Length);
        avatarImage.sprite = avatarSprites[randomIndex];
    }
}

