using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Auth;
using Firebase.Extensions;
using Firebase;
using TMPro;
using System.IO;
using Firebase.Database;
using UnityEngine.iOS;
public class accounts : MonoBehaviour
{
    public Animation showeverything;
    private string email;
    private string pass;
    public GameObject loadui;


    public char[] lista;

    public data local;
    //public settings sett;
    public GameObject banlogin;
    public TextMeshProUGUI showloading;
    public void Start()
    {
        loadui.SetActive(true);

        local.into[0] = 0;
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        if (File.Exists(Application.persistentDataPath + "/local"))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(Application.persistentDataPath + "/local"), local);
            if (local.stringo[0] != "")
            {
                login();
                showloading.text = "LOGGING IN...";
            }
            else
            {
                // sett.go();
                showloading.text = "CREATING ACCOUNT...";
                guestquicklogin();
            }
        }
        else
        {
            showloading.text = "CREATING ACCOUNT...";
            // sett.go();
            guestquicklogin();
        }
    }
    public void writer()
    {
        File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
    }


    public void guestquicklogin()
    {
        int x = Random.Range(6,20);
        string saveremail = "";
        string saverpass = "";
        for (int z = 0; z < x; z++)
        {
            int y = Random.Range(0, lista.Length-1);
            char xo = ' ';
            xo = lista[y];

            saveremail = saveremail + xo;
        }
        for (int z = 0; z < x; z++)
        {
            int y = Random.Range(0, lista.Length - 1);
            char xo = ' ';
            xo = lista[y];

            saverpass = saverpass + xo;
        }
        email = saveremail+"@gmail.com";
        pass = saverpass;
        createacc();
    }
    public void loginn()
    {
        login();
    }
    public void login()
    {
        if (local.stringo[0] == "" || local.stringo[1] == "")
        {
            showeverything.GetComponentInChildren<TextMeshProUGUI>(true).text = "Email and password cannot be empty";
            showeverything.Play();
            local.into[0] = 0;
        }
        else
        {
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
            auth.SignInWithEmailAndPasswordAsync(local.stringo[0].ToString(), local.stringo[1].ToString()).ContinueWithOnMainThread(task =>
            {

                if (task.IsFaulted)
                {
                    showeverything.Play();
                    showeverything.GetComponentInChildren<TextMeshProUGUI>(true).text = "Error email or password is invalid";
                    local.into[1] = local.into[1] + 1;
                    if (local.into[1] >= 10)
                    {
                        local.into[1] = 0;
                        banlogin.SetActive(true);
                        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
                        reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).SetValueAsync(1);
                    }

                    local.into[0] = 0;
                    writer();
                    return;
                }
                if (task.IsCompleted)
                {
                    loadui.SetActive(false);
                    local.into[1] = 0;
                    local.into[0] = 1;
                    local.stringo[2] = auth.CurrentUser.UserId;
                    writer();
                    showeverything.Play();
                    showeverything.GetComponentInChildren<TextMeshProUGUI>(true).text = "Login successful...";
                }
            });
        }
    }
    bool tryagain = false;
     void createacc()
    {
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
            auth.CreateUserWithEmailAndPasswordAsync(email.ToString(), pass.ToString()).ContinueWithOnMainThread(task =>
            {
                if(task.IsFaulted)
                {
                    if (tryagain == false)
                    {
                        tryagain = true;
                        createacc();
                    }
                }
                if (task.IsCompleted)
                {
                    local.stringo[2] = auth.CurrentUser.UserId;
                    local.stringo[0] = email.ToString();
                    local.stringo[1] = pass.ToString();
                    savedata();
                    login();
                }
            });
    }
     void savedata()
    {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        if (local.stringo[2].Length>6)
        {
            reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("email").SetValueAsync(local.stringo[0]);
            reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("pass").SetValueAsync(local.stringo[1]);
        }
    }
}

