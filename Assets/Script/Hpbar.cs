using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    public Image Hpbars;
    public float CurrenHp;
    private float MaxHp = 100f;
    PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        Hpbars = GetComponent<Image>();
        Player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrenHp = Player.health;
        Hpbars.fillAmount = CurrenHp / MaxHp;
    }
}
