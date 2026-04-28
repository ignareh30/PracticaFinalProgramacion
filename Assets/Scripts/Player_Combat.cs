using UnityEngine;

public class Player_Combat : MonoBehaviour
{
    public Animator anim;

    public void Attack()
    {
        anim.SetBool("isAttacking", true);
    }

    public void FinishingAttacking()
    {
        anim.SetBool("isAttacking", false);
    }

}
