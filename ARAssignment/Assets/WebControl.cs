using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebControl : MonoBehaviour
{
    public UniWebView view;
    public string url;
    public GameObject OpenButton;
    public GameObject CloseButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        OpenButton.SetActive(false);
        CloseButton.SetActive(true);
        view.Load(url);
        view.Show();
    }

    public void Hide()
    {
        OpenButton.SetActive(true);
        CloseButton.SetActive(false);
        view.Hide();
    }
}
