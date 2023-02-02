using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpbarPlayer : MonoBehaviour
{
    public Image HpBar;
    public float CurrenHp;
    private float MaxHp = 100f;
    PlayerController Player;
    
    // Start is called before the first frame update
    void Start()
    {
        HpBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //show Hp Player on Screen
        CurrenHp = Player.health;
        HpBar.fillAmount = CurrenHp / MaxHp;
    }
}
