using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverPowerAttack : PlayerAbility
{
    public override void UseAbility()
    {
        if (_turnTimer.IsNextTurn())
        {
            int damage = Random.Range(40, 60);
            _enemy.DealDamage(damage);
            _player.Heal();
            EndTurn();
        }

    }
}
