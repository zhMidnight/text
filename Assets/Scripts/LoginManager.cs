using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //进入前变量
    public InputField username, password;
    public Text reminderText;
    public int errorsNum;
    public Button loginButton;
    //进入后变量
    public static string myUsername;

    public void Register()
    {
        if (PlayerPrefs.GetString(username.text) == "")
        {
            if (username.text == "" || password.text == "")
            {
                reminderText.text = "请完善信息！";
            }
            else
            {
                PlayerPrefs.SetString(username.text, username.text);
                PlayerPrefs.SetString(password.text, password.text);
                reminderText.text = "注册成功！";
                username.text = " ";
                password.text = " ";
            }
            
        }
        else
        {
            reminderText.text = "用户已存在";
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
                reminderText.text = "登录成功";

                myUsername = username.text;
                // 保存玩家姓名和学号到PlayerPrefs中
                PlayerPrefs.SetString("PlayerName", myUsername);

                SceneManager.LoadScene(1);
            }
            else
            {
                reminderText.text = "学号错误";
                errorsNum++;
                if (errorsNum >= 3)
                {
                    reminderText.text = "连续错误3次，请30秒后再试！";
                    loginButton.interactable = false;
                    Invoke("Recovery", 5);
                    errorsNum = 0;
                }
            }
        }
        else
        {
            reminderText.text = "账号不存在";
        }
    }
}



