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
    public TextMeshProUGUI uid;


    public TMP_InputField emaillogin;
    public TMP_InputField passlogin;
    public Animation ani;
    public GameObject preventoverlap;
    public TextMeshProUGUI showresult;
    public data local;
    public GameObject banlogin;
    public TMP_InputField emaillogin1;
    public TMP_InputField passlogin1;
    public GameObject bindob;
    public GameObject ogme;
    private void Start()
    {
        uid.text = "User ID: " + local.stringo[2].ToString();
    }
    public void bind()
    {
        if (emaillogin.text.Length < 6 || passlogin.text.Length < 6)
        {
            showresult.text = "Email and password must be more than 5 characters";
            ani.Play();
        }
        else
        {
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
                    if (taskaa.IsCompleted)
                    {
                        auth.CurrentUser.UpdateEmailAsync(ob).ContinueWithOnMainThread(task =>
                        {

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
            showresult.text = "Email and password cannot be empty";
            ani.Play();
        }
        else
        {
            preventoverlap.SetActive(true);
            FirebaseAuth auth = FirebaseAuth.DefaultInstance;
            auth.SignInWithEmailAndPasswordAsync(emaillogin1.text.ToString(), passlogin1.text.ToString()).ContinueWithOnMainThread(task =>
            {

                if (task.IsFaulted)
                {
                    preventoverlap.SetActive(false);
                    ani.Play();
                    showresult.text = "Error email or password is invalid";
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
                if (task.IsCompleted)
                {
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
        string obz = passlogin.text;
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.CurrentUser.UpdatePasswordAsync(obz).ContinueWithOnMainThread(task =>
        {

            if (task.IsFaulted)
            {
                preventoverlap.SetActive(false);
                ani.Play();
                showresult.text = "Error password is invalid";
                return;
            }
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
