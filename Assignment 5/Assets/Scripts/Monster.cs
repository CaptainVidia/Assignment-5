/*Name: George Tang
 * File: Monster.cs
 * Project: Assignment 5
 * Description: information on monster card
 */
using UnityEngine;
using System.Collections;

public class Monster : Entity
{

    string Type = "Mosnter";
    string Ability = "Mosnter to attack other players or player's mosnters";
    int Cost = 5;
    int numSet = 1;


    public override string CardType()
    {
        return Type;
    }

    public override string CardAbility()
    {
        return Ability;
    }

    public override int CardCost()
    {
        return Cost;
    }

    public override int CardNumSet()
    {
        return numSet;
    }
}
