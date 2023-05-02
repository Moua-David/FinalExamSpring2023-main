using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dropDownLives : MonoBehaviour
{
    public Dropdown dropdown;

    private void Start()
    {
        dropdown.ClearOptions();

 
        for (int i = 1; i <= 9; i++)
        {
            dropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        }

        dropdown.onValueChanged.AddListener(delegate { DropdownValueChanged(); });
    }

    void DropdownValueChanged()
    {

        int selectedValue = dropdown.value + 1;

 
        PlayerPrefs.SetInt("lives", selectedValue);
    }
}
