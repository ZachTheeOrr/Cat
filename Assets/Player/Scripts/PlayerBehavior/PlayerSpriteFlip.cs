using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteFlip : MonoBehaviour
{
    public void FlipSprite(float mx)
    {
        if (mx != 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = Mathf.Sign(mx) * Mathf.Abs(scale.x);
            transform.localScale = scale;
        }
    }
}
