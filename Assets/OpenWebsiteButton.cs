using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWebsiteButton : MonoBehaviour
{
    public string websiteURL;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OpenWebsite);
    }

    public void OpenWebsite()
    {
         Application.OpenURL(websiteURL);
    }
}
