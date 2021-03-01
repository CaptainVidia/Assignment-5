/*Name: George Tang
 * File: Spell.cs
 * Project: Assignment 5
 * Description: information on spell card
 */
using UnityEngine;
using System.Collections;

public class Spell : Entity
{

    string Type = "Spell (BLUE)";
    string Ability = "activate or empower monster attacks and defenses";
    int Cost = 5;
    int numSet = 2;


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
