using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWeaponSprite : MonoBehaviour
{
    public Weapon weapon;
    public SpriteRenderer spriteRenderer;
    public GameObject player;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (player != null)
        {
            weapon = GameObject.Find("WeaponPlace").GetComponent<PlayerAttack>().weapon;
            spriteRenderer.sprite = weapon.weaponSprite;
        }
    }
}
