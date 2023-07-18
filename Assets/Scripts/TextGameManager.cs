using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPValueTextMeshPro, STAValueTextMeshPro;
    public string storyText;
    public int HPValue, STAValue;
    public GameObject TitleScreen, Title, TextBox, HPSTA, Level1, Level2, TryAgain, Logo, Sword, GameOv;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HPValueTextMeshPro.text = HPValue.ToString();
        STAValueTextMeshPro.text = STAValue.ToString();
    }

    //TITLE MENU
    public void TitleMenu()
    {
        HPSTA.SetActive(false);
        TextBox.SetActive(false);
        Level1.SetActive(false);
        Level2.SetActive(false);
        TryAgain.SetActive(false); 
        GameOv.SetActive(false);
        TitleScreen.SetActive(true);
        Title.SetActive(true);
        Logo.SetActive(true);
        storyText = "";
    }

    //START MENU
    public void Startbtn()
    {
        TitleScreen.SetActive(false);
        Title.SetActive(false);
        Logo.SetActive(false);
        TextBox.SetActive(true);
        HPSTA.SetActive(true);
        Level1.SetActive(true);
        Sword.SetActive(true);
        storyText = "You wake up on the ground, in pain and alone. Lying on the cold floor was once your sword, it's blade has been decayed by gloom from your previous adventures.";
    }

    public void Exitbtn()
    {
        Application.Quit();
    }

    //LEVEL 1
    public void PickUpSword()
    {
        storyText = "You obtained your half-decayed sword that whispers to you, 'You've done well'. \nYou obtained 4 health.";
        HPValue += 4;
        Level1.SetActive(false);
        Sword.SetActive(false);
        Level2.SetActive(true);
        storyText = "You find yourself outside the cave you were in. To your left, a long river invites you. To your right, a deep cave. In front of you, a snowy area.";

    }

    public void LeaveSword()
    {
        storyText = "You left the sword alone. You leave the area with no weapon.";
        Level1.SetActive(false);
        Sword.SetActive(false);
        Level2.SetActive(true);
        storyText = "You find yourself outside the cave you were in. To your left, a long river invites you. To your right, a deep cave. In front of you, a snowy area.";
    }

    public void DestroySword()
    {
        storyText = "The spirit of the sword has cursed you for destroying the sword. \nYou Died.";
        Sword.SetActive(false);
        GameOv.SetActive(true);
        HPValue = 0;
        STAValue = 0;
        Level1.SetActive(false);
        TryAgain.SetActive(true);
    }

    //LEVEL 2

    public void CrosstheRiver()
    {
        storyText = "Once you cross the river, you're shivering cold. Your body is wet and tired from swimming. Despite this, you've arrived at the Temple of Time and finished your mission.";
        HPValue -= 3;
        STAValue -= 3;
        Level2.SetActive(false);
        TryAgain.SetActive(true);
    }

    public void SnowyArea()
    {
        storyText = "You've arrived in the snowy area, the cold air decreases your health by 2 for every choice you make. Choose wisely on your next decisions.";
        HPValue -= 2;
        Level2.SetActive(false);
    }

    public void Cave()
    {
        storyText = "Entering the cave, you're embraced by the darkness. You step forward and fall into the depths of the cave. \n You lose a lot of blood and Died.";
        HPValue = 0;
        STAValue = 0;
        Level2.SetActive(false);
    }
}
