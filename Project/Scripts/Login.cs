using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField usernameField;
    public InputField passwordField;
    public Button loginButton;

    public void OnLoginButtonClick()
    {
        // Check if username and password are valid
        if (usernameField.text == "valid_username" && passwordField.text == "valid_password")
        {
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            // Display an error message
            Debug.Log("Invalid login credentials");
        }
    }


}
