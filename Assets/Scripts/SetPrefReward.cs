using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPrefReward : MonoBehaviour
{
    public Shop shop;

    public GameObject rewardPanel;

    private void Start()
    {
        Debug.Log(rewardPanel.name);
    }
    public void SetDecor()
    {
        StartCoroutine(WaitUntilShowed());
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(gameObject.name) == 1) gameObject.SetActive(false); 
    }

    IEnumerator WaitUntilShowed()
    {
        Debug.Log("Waiting for ...");
        yield return new WaitUntil(() => !ADRewardCount.RewardLocked);
        Debug.Log("Reward granted!");
        var name = gameObject.name;
        name = name.Replace("ShowRewardFor", "");
        var strings = name.Split('_');
        var id = int.Parse(strings[1]);
        PlayerPrefs.SetInt(gameObject.name, 1);
        switch(strings[0]) {
            case "Hat":
                shop.SelectHat(id);
                break;
            case "Back":
                shop.SelectBack(id);
                break;
            case "Body":
                shop.SelectBody(id);
                break;
            case "Arms":
                shop.SelectArms(id);
                break;
            case "Forearms":
                shop.SelectForeArms(id);
                break;
            case "Face":
                shop.SelectFace(id);
                break;
        }

        gameObject.SetActive(false);
        rewardPanel.SetActive(true);
    }
}
