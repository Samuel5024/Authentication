using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;


public class LoginRegister : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;

    public TextMeshProUGUI displayText;
    public void OnRegister()
    {
        RegisterPlayFabUserRequest registerRequest = new RegisterPlayFabUserRequest
        {
            Username = usernameInput.text,
            DisplayName = usernameInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false

        };

        PlayFabClientAPI.RegisterPlayFabUser(registerRequest,
            result =>
            {
                Debug.Log(result.PlayFabId);
            },
            error =>
            {
            Debug.Log(error);
            }
        );
    }

    public void OnLoginButton()
    {
        LoginWithPlayFabRequest loginRequest = new LoginWithPlayFabRequest
        {
            Username = usernameInput.text,
            Password = passwordInput.text
        };

        PlayFabClientAPI.LoginWithPlayFab(loginRequest,
            result => Debug.Log("Logged in as: " + result.PlayFabId),
            error => Debug.Log(error.ErrorMessage)
            );
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
