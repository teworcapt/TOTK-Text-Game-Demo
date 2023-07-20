using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPValueTextMeshPro, STAValueTextMeshPro;
    public string storyText;
    public int HPValue, STAValue, AcqSword;
    public GameObject TitleScreen, Title, TextBox, HPSTA, 
        Level1, Level2, Level3, Level4, Level5, Level6, 
        TryAgain, Logo, Sword, GameOv, Light, Snow, Snowfield, Temple, Lynel;


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
        Temple.SetActive(false);
        TitleScreen.SetActive(true);
        Title.SetActive(true);
        Logo.SetActive(true);
        storyText = "";
        HPValue = 10;
        STAValue = 10;
        AcqSword = 0;
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
        storyText = "You wake up on the ground, in pain and alone. Lying on the cold floor was once your sword, it's blade has been decayed by gloom from your previous adventures.\n\n A voice from the sword speaks, 'Return to the Temple of Time.'";
    }

    public void Exitbtn()
    {
        Application.Quit();
    }

    //LEVEL 1
    public void PickUpSword()
    {
        storyText = "You obtained your half-decayed sword that whispers to you, 'You've chosen wisely'. \nYou obtained 4 health.";
        HPValue += 4;
        AcqSword += 5;
        Level1.SetActive(false);
        Sword.SetActive(false);
        Level2.SetActive(true);
        storyText = "You find yourself outside the cave you were in. The sun shines brightly to your eyes. As you adjust to the sudden light, you notice your surroundings; \nTo your left, a long river invites you. \nTo your right, a deep cave with promising treasure tempts you. \nIn front of you, there are mountains that are blanketed with white snow.";

    }

    public void LeaveSword()
    {
        storyText = "You left the sword alone. You leave the area with no weapon.";
        Level1.SetActive(false);
        Sword.SetActive(false);
        Level2.SetActive(true);
        storyText = "You find yourself outside the cave you were in. The sun shines brightly to your eyes. As you adjust to the sudden light, you notice your surroundings; \nTo your left, a long river invites you. \nTo your right, a deep cave with promising treasure tempts you. \nIn front of you, there are mountains that are blanketed with white snow.";
    }

    public void DestroySword()
    {
        storyText = "'You've done a grave mistake.' The spirit of the blade has cursed you for destroying the sword. \n\nYou died.";
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
        Temple.SetActive(true);
        TryAgain.SetActive(true);
    }

    public void SnowyArea()
    {
        storyText = "You've arrived in the snowy area, the cold air decreases your health by 2 for every choice you make. Choose wisely on your next decisions.";
        HPValue -= 2;
        Level2.SetActive(false);
        Snow.SetActive(true);
        Level3.SetActive(true);
    }

    public void Cave()
    {
        storyText = "Entering the cave, you're embraced by the darkness. You step forward and fall into the depths of the cave. \n \n You fell to your death.";
        HPValue = 0;
        STAValue = 0;
        Level2.SetActive(false);
        GameOv.SetActive(true);
        TryAgain.SetActive(true);
    }

    //LEVEL 3
    public void Avalanche()
    {
        storyText = "As you climb up the snowy mountain, an avalanche happened. This causes you to lose 2 hearts and 2 stamina. \n\nGoing forward, you get lost in the snow. The whiteness starts to blind you as you stumble and found yourself in an open snowfield.";
        HPValue -= 4;
        STAValue -= 2;
        Snow.SetActive(false);
        Level3.SetActive(false);
        Snowfield.SetActive(true);
        Level4.SetActive(true);
    }

    public void Camp()
    {
        storyText = "Seeing smoke from afar, you went to the camp. There, you are greeted by travelers with a meal and some stories. The delicious stew gave you 5 hearts and 5 stamina.\n\nGoing forward, you get lost in the snow. The whiteness starts to blind you as you stumble and found yourself in an open snowfield.";
        HPValue += 5;
        STAValue += 5;
        Snow.SetActive(false);
        Level3.SetActive(false);
        Snowfield.SetActive(true);
        Level4.SetActive(true);
    }

    public void Snowboard()
    {
        storyText = "Snowboarding down the snowy mountain. You found bumped into a tree. The tree's spirit teleports you to the front of the Temple of Time.";
        HPValue -= 2;
        Snow.SetActive(false);
        Level3.SetActive(false);
        Temple.SetActive(true);
        TryAgain.SetActive(true);
    }


    //LEVEL 4
    public void ContinueForth()
    {
        storyText = "The open field makes you nervous, for a good reason too. A half-lion, half-horse beast shows up behind you. \n\nIt's a Lynel.";
        Snowfield.SetActive(false);
        Level4.SetActive(false);
        Lynel.SetActive(true);
        Level5.SetActive(true);
    }


    //LEVEL 5
    public void Lynel_Fight()
    {
        if (AcqSword <= 0)
        {
            Lynel_Noweapon();
        } else
        {
            Lynel_Weapon();
        }
        Level5.SetActive(false);
        Level6.SetActive(true);
    }


    public void Lynel_Noweapon()
    {
        storyText = "Fighting the lynel, you've readied yourself. Having a weapon could've been great in this situation, but you don't have one. \n\nThe lynel makes easy work of you, hitting you decreased your hearts by 5.";
        Lynel.SetActive(true);
        HPValue -= 5;

    }

    public void Lynel_Weapon()
    {
        storyText = "With your weapon, you braced the beast. \n\nYou penetrate it with your half-decayed sword, sealing its fate with death. \n\nDespite this, the Lynel did a blow to your leg. \nYou're bleeding.";
        HPValue -= 4;
        STAValue -= 2;
        Lynel.SetActive(true);
        Level5.SetActive(false);
        Level6.SetActive(true);
    }

    public void Lynel_Scene()
    {
        if (HPValue <= 0)
        {
            Lynel_Death();
        }
        else if (STAValue <= 0)
        {
            Caught();
        }
        else
        {
            Lynel_Survive();
        }
    }

    public void Lynel_Survive()
    {
        storyText = "You survived the Lynel, you're bleeding but you survived.\n\nYou arrived at the Temple of Time.";
        HPValue -= 2;
        STAValue -= 2;
        Level6.SetActive(false);
        Lynel.SetActive(false);
        Temple.SetActive(true);
        TryAgain.SetActive(true);
    }

    //Extra death scene
    public void Lynel_Death()
    {
        storyText = "You died due to losing too much blood from the Lynel's attacks.";
        HPValue = 0;
        STAValue = 0;
        Lynel.SetActive(false);
        Level6.SetActive(false);
        GameOv.SetActive(true);
        TryAgain.SetActive(true);
    }

    //LEVEL 5 RUN
    public void Runaway()
    {
        storyText = "You ran trying to lose the Lynel but they were fast and you were losing stamina.";
        HPValue -= 2;
        STAValue -= 10;
        Level5.SetActive(false);
        Lynel.SetActive(true) ;
        Level6.SetActive(true) ;
    }

    public void Caught()
    {

        storyText = "You got caught by the Lynel. It deals a heavy blow to you, killing you instantly.";
        HPValue = 0;
        STAValue = 0;
        Lynel.SetActive(false);
        Level6.SetActive(false);
        GameOv.SetActive(true);
        TryAgain.SetActive(true);

    }

}
