
using UnityEngine;
using System.Collections;

// Die subclass to expose the D6 side hitVectors
public class Die_d6 : Die {
		
    override protected Vector3 HitVector(int side)
    {
        switch (side)
        {
            case 1: return new Vector3(0F, 0F, 1F);
            case 2: return new Vector3(0F, -1F, 0F);
            case 3: return new Vector3(-1F, 0F, 0F);
            case 4: return new Vector3(1F, 0F, 0F);
            case 5: return new Vector3(0F, 1F, 0F);
            case 6: return new Vector3(0F, 0F, -1F);
        }
        return Vector3.zero;
    }
		
}
