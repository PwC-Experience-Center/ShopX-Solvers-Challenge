using UnityEngine;

public class WebpageOpener : MonoBehaviour
{
    public string webpageURL;

    public void OpenWebpage()
    {
        Application.OpenURL(webpageURL);
    }
}
