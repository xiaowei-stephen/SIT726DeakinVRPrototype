using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public static bool PanelIsOpened = false;

    public GameObject Camera;
    public GameObject controlPanelUI;
    public GameObject Friend, Friend2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (PanelIsOpened)
            {
                ClosePanel();
            }
            else
            {
                OpenPanel();
            }
        }
    }

    void ClosePanel()
    {
        foreach (Transform child in transform)
            child.gameObject.SetActive(false);
        PanelIsOpened = false;
    }
    void OpenPanel()
    {
        controlPanelUI.SetActive(true);
        PanelIsOpened = true;
    }

    public void Join()
    {
        GameObject spawnPoint = GameObject.Find("JoinPlayer");
        Camera.transform.position = spawnPoint.transform.position;
        GameObject spawnPoint2 = GameObject.Find("JoinFriend");
        Instantiate(Friend2, spawnPoint2.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    public void Event()
    {
        GameObject spawnPoint = GameObject.Find("EventPlayer");
        Camera.transform.position = spawnPoint.transform.position;
        GameObject spawnPoint2 = GameObject.Find("EventFriend");
        GameObject spawnPoint3 = GameObject.Find("EventFriend2");
        Instantiate(Friend, spawnPoint2.transform.position, Quaternion.identity);
        Instantiate(Friend2, spawnPoint3.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    public void Create()
    {
        GameObject spawnPoint = GameObject.Find("TennisPlayer");
        Camera.transform.position = spawnPoint.transform.position;
    }

    public void Invite()
    {
        GameObject spawnPoint = GameObject.Find("TennisFriend");
        Instantiate(Friend, spawnPoint.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
    }

    public void Leave()
    {
        GameObject spawnPoint = GameObject.Find("Origin");
        Camera.transform.position = spawnPoint.transform.position;
    }

    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
