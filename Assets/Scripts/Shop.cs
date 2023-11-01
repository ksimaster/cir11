using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject placeHat;
    public GameObject placeBack;
    public GameObject placeBody;
    public GameObject placeFace;
    public GameObject placeArmsLeft;
    public GameObject placeArmsRight;
    public GameObject placeForearmsLeft;
    public GameObject placeForearmsRight;

    public GameObject imageHat_0;
    public GameObject imageHat_1;
    public GameObject imageHat_2;
    public GameObject imageBack_0;
    public GameObject imageBack_1;
    public GameObject imageBack_2;
    public GameObject imageBody_0;
    public GameObject imageBody_1;
    public GameObject imageBody_2;
    public GameObject imageFace_0;
    public GameObject imageFace_1;
    public GameObject imageFace_2;
    public GameObject imageArms_0;
    public GameObject imageArms_1;
    public GameObject imageForearms_0;
    public GameObject imageForearms_1;



    private int i = 0;
    private int countDecorHats;
    private int countDecorBacks;
    private int countDecorBody;
    private int countDecorFace;
    private int countDecorArmsLeft;
    private int countDecorArmsRight;
    private int countDecorForearmsLeft;
    private int countDecorForearmsRight;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Hat")) PlayerPrefs.SetInt("Hat", 0);
        if (!PlayerPrefs.HasKey("Back")) PlayerPrefs.SetInt("Back", 0);
        if (!PlayerPrefs.HasKey("Body")) PlayerPrefs.SetInt("Body", 0);
        if (!PlayerPrefs.HasKey("Face")) PlayerPrefs.SetInt("Face", 0);
        if (!PlayerPrefs.HasKey("Arms")) PlayerPrefs.SetInt("Arms", 0);
        if (!PlayerPrefs.HasKey("Forearms")) PlayerPrefs.SetInt("Forearms", 0);
        countDecorHats = placeHat.transform.childCount;
        countDecorBacks = placeBack.transform.childCount;
        countDecorBody = placeBody.transform.childCount;
        countDecorFace = placeFace.transform.childCount;
        countDecorArmsLeft = placeArmsLeft.transform.childCount;
        countDecorArmsRight = placeArmsRight.transform.childCount;
        countDecorForearmsLeft = placeForearmsLeft.transform.childCount;
        countDecorForearmsRight = placeForearmsRight.transform.childCount;
        LoadStart();
    }

    public void LoadStart()
    {
        ResetDecor(placeHat, countDecorHats);
        ResetDecor(placeBack, countDecorBacks);
        ResetDecor(placeBody, countDecorBody);
        ResetDecor(placeFace, countDecorFace);
        ResetDecor(placeArmsLeft, countDecorArmsLeft);
        ResetDecor(placeArmsRight, countDecorArmsRight);
        ResetDecor(placeForearmsLeft, countDecorForearmsLeft);
        ResetDecor(placeForearmsRight, countDecorForearmsRight);
        placeHat.transform.GetChild(PlayerPrefs.GetInt("Hat")).gameObject.SetActive(true);
        placeBack.transform.GetChild(PlayerPrefs.GetInt("Back")).gameObject.SetActive(true);
        placeBody.transform.GetChild(PlayerPrefs.GetInt("Body")).gameObject.SetActive(true);
        placeFace.transform.GetChild(PlayerPrefs.GetInt("Face")).gameObject.SetActive(true);
        placeArmsLeft.transform.GetChild(PlayerPrefs.GetInt("Arms")).gameObject.SetActive(true);
        placeArmsRight.transform.GetChild(PlayerPrefs.GetInt("Arms")).gameObject.SetActive(true);
        placeForearmsLeft.transform.GetChild(PlayerPrefs.GetInt("Forearms")).gameObject.SetActive(true);
        placeForearmsRight.transform.GetChild(PlayerPrefs.GetInt("Forearms")).gameObject.SetActive(true);

        switch (PlayerPrefs.GetInt("Hat"))
        {
            case 0:
                imageHat_0.SetActive(true);
                break;
            case 1:
                imageHat_1.SetActive(true);
                break;
            case 2:
                imageHat_2.SetActive(true);
                break;
        }

        switch (PlayerPrefs.GetInt("Back"))
        {
            case 0:
                imageBack_0.SetActive(true);
                break;
            case 1:
                imageBack_1.SetActive(true);
                break;
            case 2:
                imageBack_2.SetActive(true);
                break;
        }

        switch (PlayerPrefs.GetInt("Body"))
        {
            case 0:
                imageBody_0.SetActive(true);
                break;
            case 1:
                imageBody_1.SetActive(true);
                break;
            case 2:
                imageBody_2.SetActive(true);
                break;
        }
        
        switch (PlayerPrefs.GetInt("Face"))
        {
            case 0:
                imageFace_0.SetActive(true);
                break;
            case 1:
                imageFace_1.SetActive(true);
                break;
            case 2:
                imageFace_2.SetActive(true);
                break;
        }

        switch (PlayerPrefs.GetInt("Arms"))
        {
            case 0:
                imageArms_0.SetActive(true);
                break;
            case 1:
                imageArms_1.SetActive(true);
                break;
        }

        switch (PlayerPrefs.GetInt("Forearms"))
        {
            case 0:
                imageForearms_0.SetActive(true);
                break;
            case 1:
                imageForearms_1.SetActive(true);
                break;
        }
    }

    public void ResetDecor(GameObject placeOnPerk, int count)
    {
        for (int j = 0; j < count; j++)
        {
            placeOnPerk.transform.GetChild(j).gameObject.SetActive(false);
        }
        placeOnPerk.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SelectHat(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeHat, countDecorHats);
        PlayerPrefs.SetInt("Hat", numberDecor);
        placeHat.transform.GetChild(numberDecor).gameObject.SetActive(true);
        Debug.Log("Ўл€па выбрана под номером " + PlayerPrefs.GetInt("Hat"));
    }

    public void SelectBack(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeBack, countDecorBacks);
        PlayerPrefs.SetInt("Back", numberDecor);
        placeBack.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }

    public void SelectBody(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeBody, countDecorBody);
        PlayerPrefs.SetInt("Body", numberDecor);
        placeBody.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }
    public void SelectFace(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeFace, countDecorFace);
        PlayerPrefs.SetInt("Face", numberDecor);
        placeFace.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }
    public void SelectArms(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeArmsLeft, countDecorArmsLeft);
        ResetDecor(placeArmsRight, countDecorArmsRight);
        PlayerPrefs.SetInt("Arms", numberDecor);
        placeArmsLeft.transform.GetChild(numberDecor).gameObject.SetActive(true);
        placeArmsRight.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }
    public void SelectForeArms(int numberDecor)
    {
        // 0 - none (empty object), 1 - first decor, 2 - second decor...
        ResetDecor(placeForearmsLeft, countDecorForearmsLeft);
        ResetDecor(placeForearmsRight, countDecorForearmsRight);
        PlayerPrefs.SetInt("Forearms", numberDecor);
        placeForearmsLeft.transform.GetChild(numberDecor).gameObject.SetActive(true);
        placeForearmsRight.transform.GetChild(numberDecor).gameObject.SetActive(true);
    }
}
