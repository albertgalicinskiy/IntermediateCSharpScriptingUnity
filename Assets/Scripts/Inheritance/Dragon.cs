using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Enemy
{
    public bool attacking = false;

    private void Update() {
        if (attacking)
        {
            // if we have the same function inside this class
            // the function will be called in this class
            Attack();

            // what if we want to use function in parent
            // class while we having the same function declared in this class
            //base.Attack(); // this function will be called from Enemy class

            

        }
    }

    // void Attack()
    // {
    //     print("Dragon Attack");
    // }


}
