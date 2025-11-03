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

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
