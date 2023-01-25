using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData",menuName = "MyCardData/CardData")]
public class CardData : ScriptableObject
{
    [SerializeField] Character character;
    public Character Char { get { return character; } }
    [SerializeField] float speed;
    public float Speed { get; set; }

    [SerializeField] int cost;
    public int Cost { get; set; }
}
