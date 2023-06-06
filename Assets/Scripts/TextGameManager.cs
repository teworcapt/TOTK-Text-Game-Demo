using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPValueTextMeshPro, STAValueTextMeshPro;
    public string storyText;
    public int HPValue, STAValue;
    public GameObject TitleScreen, TextBox, HPSTA, Level1, Level2, Logo, Sword;


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

    //START MENU
    public void Startbtn()
    {
        TitleScreen.SetActive(false);
        Logo.SetActive(false);
        TextBox.SetActive(true);
        HPSTA.SetActive(true);
        Level1.SetActive(true);
        Sword.SetActive(true);
        storyText = "Lying on the cold floor was once your sword. As you observe it, it has been corrupted with only half of it being usable.";
    }

    public void Exitbtn()
    {
        Application.Quit();
    }

    //LEVEL 1
    public void PickUpSword()
    {
        storyText = "You obtained a half-corrupted sword that whispers to you, 'You've done well'. \n You obtained 5 health.";
        HPValue += 5;
        Level1.SetActive(false);
        Level2.SetActive(true);
        Sword.SetActive(false);
        storyText = "You find yourself outside the cave you were in. To your left, a long river invites you. To your right, a deep cave. In front of you, a snowy area.";

    }

    public void LeaveSword()
    {
        storyText = "You left the sword alone. You leave the area with no weapon.";
        Level1.SetActive(false);
        Level2.SetActive(true);
        storyText = "You find yourself outside the cave you were in. To your left, a long river invites you. To your right, a deep cave. In front of you, a snowy area.";
    }

    public void DestroySword()
    {
        storyText = "The spirit of the sword has cursed you for destroying the sword. \n You Died.";
        HPValue = 0;
        STAValue = 0;
        Level1.SetActive(false);
    }

    //LEVEL 2

    public void CrosstheRiver()
    {
        storyText = "Once you cross the river, you're  shivering cold. Your body is wet and tired from swimming. \n You lost 5 health and 5 stamina.";
        HPValue -= 5;
        STAValue -= 5;
        Level2.SetActive(false);
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
