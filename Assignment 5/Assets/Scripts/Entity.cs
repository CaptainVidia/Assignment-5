/*Name: George Tang
 * File: Entity.cs
 * Project: Assignment 5
 * Description: methods for all Entity children for card stats
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Entity : MonoBehaviour
{
    public abstract string CardType();
    public abstract string CardAbility();
    public abstract int CardCost();
    public abstract int CardNumSet();
}
