/*Name: George Tang
 * File: Spell.cs
 * Project: Assignment 5
 * Description: information on special card
 */
using UnityEngine;
using System.Collections;

public class Special : Entity
{
    string Type = "Special";
    string Ability = "activate mosnter special ability";
    int Cost = 10;
    int numSet = 3;


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
