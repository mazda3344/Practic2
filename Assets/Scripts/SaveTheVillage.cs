using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public TMP_Text EnemiesNumber;
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
    public GameObject GameOverScreen;
    public Button RestartIfLost;
    public Button RestartIfWin;
    public GameObject YOUWIN;
    void Start()
    {
        UpdateText();
        Time.timeScale = 1;
        RaidTimer = RaidMaxTime;

    }

    void Update()
    {
        if (PeasantCount >= 20 || WarriorsCount >= 20)
        {
            Time.timeScale = 0;
            YOUWIN.SetActive(true);
        }
        RaidTimer -= Time.deltaTime;
        RaidTimerImg.fillAmount = RaidTimer / RaidMaxTime;
        if (RaidTimer <= 0)
        {
            RaidTimer = RaidMaxTime;
            WarriorsCount -= NextRaid;
            NextRaid += RaidIncrease;
        }
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
            PeasantTimerImg.fillAmount = 1;
            PeasantButton.interactable = true;
            PeasantCount += 1;
            PeasantTimer = -2;
        }
        if (WarriorTimer > 0)
        {
            WarriorTimer -= Time.deltaTime;
            WarriorTimerImg.fillAmount = WarriorTimer / WarriorCreateTime;
        }
        else if (WarriorTimer > -1)
        {
            WarriorTimerImg.fillAmount = 1;
            WarriorButton.interactable = true;
            WarriorsCount += 1;
            WarriorTimer = -2;
        }
        if (WheatCount <= 0)
        {
            PeasantButton.interactable = false;
            WarriorButton.interactable = false;
        }
        if (WheatCount > 0)
        {
            WarriorButton.interactable = true;
            PeasantButton.interactable = true;
        }

        UpdateText();
        if (WarriorsCount < 0)
        {
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
        }
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
        ResourcesText.text = PeasantCount + "\n" + WarriorsCount + "\n\n" + WheatCount + "\n" + NextRaid;

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);

    }


}