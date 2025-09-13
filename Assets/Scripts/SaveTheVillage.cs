using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class savethevillage : MonoBehaviour
{
    public Timer HarvestTImer;
    public Timer EatingTimer;
    public Image RaidTimerImg;
    public Image WarriorTimerImg;
    public Image PeasantTimerImg;
    public Button PeasantButton;
    public Button WarriorButton;
    public Text ResourcesText;
    public int PesantCount;
    public int WheatCount;
    public int WarriorsCount;
    public int WheatPerPeasant;
    public int WheatToWarriors;
    public int PesantCost;
    public int WarriorsCost;
    public float PeacantCreateTime;
    public float WarriorCreateTime;
    public float RaidMaxTime;
    public int RaidIncrease;
    public int NextRaid;
    private float PeasantTimer = -2;
    private float WarriorTimer = -2;
    void Start()
    {

    }
    void Update()
    {

    }
    public void PeacantCreate()
    {

    }
    public void WarriorCreate()
    {

    }
    private void UpdateText()
    {
        ResourcesText.text = PesantCount + "\n" + WarriorsCount + "\n\n" + WheatCount;

    }


}