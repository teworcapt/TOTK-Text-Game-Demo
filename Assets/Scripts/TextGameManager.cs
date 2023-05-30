using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HPValueTextMeshPro, STAValueTextMeshPro;
    public string storyText;
    public int HPValue, STAValue;
    public GameObject Level1;
    public GameObject Level2;

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

    public void PickUpSword()
    {
        storyText = "You obtained a half-corrupted sword that whispers to you, 'You've done well'. You obtained 5 health.";
        HPValue += 5;
        Level1.SetActive(false);
        Level2.SetActive(true);
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
        storyText = "The spirit of the sword has cursed you for destroying the sword. You Died.";
        STAValue -= 10;
        Level1.SetActive(false);
    }
}
