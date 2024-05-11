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
public class accounts : MonoBehaviour
{
    //text to show animation
    public Animation showeverything;
    //saved email and password
    private string email;
    private string pass;
    //an object that shows that the game is loading
    public GameObject loadui;

    //a char list used to generate guest account
    public char[] lista;

    //a scriptable object used to store email and password locally
    public data local;
   //a gameobject that shows that the user has been banned
    public GameObject banlogin;
    //a text that shows loading
    public TextMeshProUGUI showloading;
    //starting animation
    public Animation stani;
    public void Start()
    {
        //turn load objective on to mark that it is loading
        loadui.SetActive(true);
        //mark as signed out
        local.into[0] = 0;
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        //read local file called local, if doesn't exist means first time opening the application or deleted the app data then opened the game
        if (File.Exists(Application.persistentDataPath + "/local"))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(Application.persistentDataPath + "/local"), local);
            if (local.stringo[0] != "")
            {
                //login using the saved local values
                login();
                //show loading text
                showloading.text = "LOGGING IN...";
            }
            else
            {
                //show loading text
                showloading.text = "CREATING ACCOUNT...";
                //create account since data is corrupted or doesn't exist
                guestquicklogin();
            }
        }
        else
        {
            //show loading text
            showloading.text = "CREATING ACCOUNT...";
            //log in as guest since first time loading
            guestquicklogin();
        }
    }
    public void writer()
    {
        //save data to file called local in JSON format
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
    public void login()
    {

        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        //check if the user device was banned
        reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).GetValueAsync().ContinueWithOnMainThread(task =>
        {

            if (task.IsCompleted)
            {
                DataSnapshot snap = task.Result;
                if (snap.Exists == false)
                {
                    //make sure password and email arne't empty, if yes throw an animation
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
                            //if login failed
                            if (task.IsFaulted)
                            {
                                //play animation that login failed and increase ban counter by 1
                                showeverything.Play();
                                showeverything.GetComponentInChildren<TextMeshProUGUI>(true).text = "Error email or password is invalid";
                                local.into[1] = local.into[1] + 1;
                                if (local.into[1] >= 10)
                                {
                                    //if value reaches 10 ban and show gameobject that the user was banned
                                    local.into[1] = 0;
                                    banlogin.SetActive(true);
                                    reference = FirebaseDatabase.DefaultInstance.RootReference;
                                    reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).SetValueAsync(1);
                                }

                                local.into[0] = 0;
                                writer();
                                return;
                            }
                            if (task.IsCompleted)
                            {
                                //play the animation that login was sucessful, write the login details to the phone local storage
                                stani.Play();
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
                else
                {
                    loadui.SetActive(false);
                    banlogin.SetActive(true);
                }
            }
        });
        
    }
    bool tryagain = false;
     void createacc()
    {
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
        //this attempts to create an account on firebase using the saved email and password
            auth.CreateUserWithEmailAndPasswordAsync(email.ToString(), pass.ToString()).ContinueWithOnMainThread(task =>
            {
                if(task.IsFaulted)
                {
                    //if fails to create account retry once again only (assuming it failed once due to outside reason (connection lost)
                    if (tryagain == false)
                    {
                        tryagain = true;
                        createacc();
                    }
                }
                if (task.IsCompleted)
                {
                    //save account details to local scriptable objects
                    local.stringo[2] = auth.CurrentUser.UserId;
                    local.stringo[0] = email.ToString();
                    local.stringo[1] = pass.ToString();
                    //save local to the phone storage
                    savedata();
                    //it attempt to login
                    login();
                }
            });
    }
     void savedata()
    {
        //save email and password on the database in case of password forgetting
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        if (local.stringo[2].Length>6)//this makes sure the user is logged in
        {
            reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("email").SetValueAsync(local.stringo[0]);
            reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("pass").SetValueAsync(local.stringo[1]);
        }
    }
}

