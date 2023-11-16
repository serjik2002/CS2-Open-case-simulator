using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Rarest
{
    Common,
    Uncommon,
    Rare,
    Mythical,
    Legendary,
    Ancient,
    ExceedinglyRare,
    Immortal
}
[CreateAssetMenu]
public class Item : ScriptableObject
{
    public Sprite _sprite;
    public Text _label;
    public Rarest _rarest;

}
