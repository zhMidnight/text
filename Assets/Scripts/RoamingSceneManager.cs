using UnityEngine;
using UnityEngine.UI;

public class RoamingSceneManager : MonoBehaviour
{
    public Image avatarImage;
    public Text playerNameText;

    public Sprite[] avatarSprites; // ͷ���

    void Start()
    {
        // ��PlayerPrefs�л�ȡ�������
        string playerName = PlayerPrefs.GetString("PlayerName");
        playerNameText.text = playerName;

        // ��ͷ��������ѡ��һ��ͷ��
        int randomIndex = Random.Range(0, avatarSprites.Length);
        avatarImage.sprite = avatarSprites[randomIndex];
    }
}

