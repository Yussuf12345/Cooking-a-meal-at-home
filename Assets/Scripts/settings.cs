using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Firebase.Auth;
using Firebase.Extensions;
using Firebase;
using System.IO;
using Firebase.Database;
public class settings : MonoBehaviour
{
    //text filed that shows the user ID
    public TextMeshProUGUI uid;

    //text input field that takes binding email and password
    public TMP_InputField emaillogin;
    public TMP_InputField passlogin;
    //result animation reference
    public Animation ani;
    //block actions until switch/bind is done to prevent spam
    public GameObject preventoverlap;
    //animation text
    public TextMeshProUGUI showresult;
    //object to store email and password
    public data local;
    //banned object
    public GameObject banlogin;
    //text input field that takes switching account email and password
    public TMP_InputField emaillogin1;
    public TMP_InputField passlogin1;
    //binding menu
    public GameObject bindob;
    //settings start menu
    public GameObject ogme;
    private void Start()
    {
        //show the user ID
        uid.text = "User ID: " + local.stringo[2].ToString();
    }
    public void bind()
    {
        //make sure email and password are valid
        if (emaillogin.text.Length < 6 || passlogin.text.Length < 6)
        {
            showresult.text = "Email and password must be more than 5 characters";
            ani.Play();
        }
        else
        {
            //trun block object on
            preventoverlap.SetActive(true);
            Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            string ob = emaillogin.text;

            Firebase.Auth.FirebaseUser user = auth.CurrentUser;
            Firebase.Auth.Credential credential =
    Firebase.Auth.EmailAuthProvider.GetCredential(local.stringo[0].ToString(), local.stringo[1].ToString());
            if (user != null)
            {
                user.ReauthenticateAsync(credential).ContinueWith(taskaa =>
                {
                    if (taskaa.IsFaulted)
                    {
                        //show error that email is invalid (refused by firebase) and increase count by 1
                        preventoverlap.SetActive(false);
                        ani.Play();
                        showresult.text = "Error email is invalid";
                        local.into[1] = local.into[1] + 1;
                        if (local.into[1] >= 10)
                        { //if value reaches 10 ban and show gameobject that the user was banned
                            local.into[1] = 0;
                            banlogin.SetActive(true);
                            DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
                            reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).SetValueAsync(1);
                        }
                        File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
                        return;
                    }
                    if (taskaa.IsCompleted)
                    {
                        auth.CurrentUser.UpdateEmailAsync(ob).ContinueWithOnMainThread(task =>
                        {
                            //binding is split into 2 parts, email binding then password binding, here it calls binding password if email binding is successful
                            if (task.IsFaulted)
                            {
                                Debug.Log(task.Exception);
                                preventoverlap.SetActive(false);
                                ani.Play();
                                showresult.text = "Error email is invalid";
                                local.into[1] = local.into[1] + 1;
                                if (local.into[1] >= 10)
                                {
                                    local.into[1] = 0;
                                    banlogin.SetActive(true);
                                    DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
                                    reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).SetValueAsync(1);
                                }
                                File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
                                return;
                            }
                            local.stringo[0] = emaillogin.text.ToString();
                            updtpass();
                        });
                    }
                });
            }

        }
    }
    public void switchacc()
    {
        if (emaillogin1.text == "" || passlogin1.text == "")
        {
            //make sure email and password are valid
            showresult.text = "Email and password cannot be empty";
            ani.Play();
        }
        else
        { //trun block object on
            preventoverlap.SetActive(true);
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
            auth.SignInWithEmailAndPasswordAsync(emaillogin1.text.ToString(), passlogin1.text.ToString()).ContinueWithOnMainThread(task =>
            {

                if (task.IsFaulted)
                { //show error that email is invalid (refused by firebase) and increase count by 1
                    preventoverlap.SetActive(false);
                    ani.Play();
                    showresult.text = "Error email or password is invalid";
                    local.into[1] = local.into[1] + 1;
                    if (local.into[1] >= 10)
                    {
                        //if value reaches 10 ban and show gameobject that the user was banned
                        local.into[1] = 0;
                        banlogin.SetActive(true);
                        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
                        reference.Child("ban").Child(SystemInfo.deviceUniqueIdentifier.ToString()).SetValueAsync(1);
                    }
                    File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
                    return;
                }
                if (task.IsCompleted)
                {                           
                    //here it saves the new email, password and  restarts the app with the new account
                    local.into[1] = 0;
                    preventoverlap.SetActive(false);
                    local.stringo[0] = emaillogin1.text.ToString();
                    local.stringo[2] = auth.CurrentUser.UserId;
                    local.stringo[1] = passlogin1.text.ToString();
                    File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
                    ani.Play();
                    showresult.text = "Login successful...";
                    SceneManager.LoadScene("Mainscene");
                }
            });
        }
    }
    void updtpass()
    {
        //attempt to update the password
        string obz = passlogin.text;
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.CurrentUser.UpdatePasswordAsync(obz).ContinueWithOnMainThread(task =>
        {
            //show error that email is invalid (refused by firebase)
            if (task.IsFaulted)
            {
                preventoverlap.SetActive(false);
                ani.Play();
                showresult.text = "Error password is invalid";
                return;
            }  
            //here it updates to the new password and shows the animation accordingly, the sends the new email and password to the database
            preventoverlap.SetActive(false);
            local.stringo[1] = passlogin.text.ToString();
            ani.Play();
            showresult.text = "Account succesfully bound";
            File.WriteAllText(Application.persistentDataPath + "/local", JsonUtility.ToJson(local));
            DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
            bindob.SetActive(false);
            ogme.SetActive(true);
            if (local.stringo[2].Length > 6)
            {
                reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("email").SetValueAsync(local.stringo[0]);
                reference.Child("emailpass").Child(local.stringo[2].ToString()).Child("pass").SetValueAsync(local.stringo[1]);
            }
        });
    }
}
