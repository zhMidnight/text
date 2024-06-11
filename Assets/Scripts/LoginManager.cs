using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //����ǰ����
    public InputField username, password;
    public Text reminderText;
    public int errorsNum;
    public Button loginButton;
    //��������
    public static string myUsername;

    public void Register()
    {
        if (PlayerPrefs.GetString(username.text) == "")
        {
            if (username.text == "" || password.text == "")
            {
                reminderText.text = "��������Ϣ��";
            }
            else
            {
                PlayerPrefs.SetString(username.text, username.text);
                PlayerPrefs.SetString(password.text, password.text);
                reminderText.text = "ע��ɹ���";
                username.text = " ";
                password.text = " ";
            }
            
        }
        else
        {
            reminderText.text = "�û��Ѵ���";
        }

    }
    private void Recovery()
    {
        loginButton.interactable = true;
    }
    public void Login()
    {
        if (PlayerPrefs.GetString(username.text) != "")
        {
            if (PlayerPrefs.GetString(password.text) == password.text)
            {
                reminderText.text = "��¼�ɹ�";

                myUsername = username.text;
                // �������������ѧ�ŵ�PlayerPrefs��
                PlayerPrefs.SetString("PlayerName", myUsername);

                SceneManager.LoadScene(1);
            }
            else
            {
                reminderText.text = "ѧ�Ŵ���";
                errorsNum++;
                if (errorsNum >= 3)
                {
                    reminderText.text = "��������3�Σ���30������ԣ�";
                    loginButton.interactable = false;
                    Invoke("Recovery", 5);
                    errorsNum = 0;
                }
            }
        }
        else
        {
            reminderText.text = "�˺Ų�����";
        }
    }
}



