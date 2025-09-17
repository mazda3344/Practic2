using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class savethevillage : MonoBehaviour
{
    public Timer HarvestTimer;
    public Timer EatingTimer;
    public Image RaidTimerImg;
    public Image WarriorTimerImg;
    public Image PeasantTimerImg;
    public Button PeasantButton;
    public Button WarriorButton;
    public TMP_Text ResourcesText;
    public int PeasantCount;
    public int WheatCount;
    public int WarriorsCount;
    public int WheatPerPeasant;
    public int WheatToWarriors;
    public int PesantCost;
    public int WarriorsCost;
    public float PeasantCreateTime;
    public float WarriorCreateTime;
    public float RaidMaxTime;
    public int RaidIncrease;
    public int NextRaid;
    private float PeasantTimer = -2;
    private float WarriorTimer = -2;
    private float RaidTimer;
    void Start()
    {
        UpdateText();
    }
    void Update()
    {
        if (HarvestTimer.Tick)
        {
            WheatCount += PeasantCount * WheatPerPeasant;
        }
        if (EatingTimer.Tick)
        {
            WheatCount -= WarriorsCount * WheatToWarriors;
        }
        if (PeasantTimer > 0)
        {
            PeasantTimer -= Time.deltaTime;
            PeasantTimerImg.fillAmount = PeasantTimer / PeasantCreateTime;
        }
        else if (PeasantTimer > -1)
        {
            PeasantButton.interactable = true;
            PeasantCount += 1;
            PeasantTimer = -2;
        }

        UpdateText();
    }
    public void PeacantCreate()
    {
        WheatCount -= PesantCost;
        PeasantTimer = PeasantCreateTime;
        PeasantButton.interactable = false;
    }
    public void WarriorCreate()
    {
        WheatCount -= WarriorsCost;
        WarriorTimer = WarriorCreateTime;
        WarriorButton.interactable = false;
    }
    private void UpdateText()
    {
        ResourcesText.text = PeasantCount + "\n" + WarriorsCount + "\n\n" + WheatCount;

    }


}