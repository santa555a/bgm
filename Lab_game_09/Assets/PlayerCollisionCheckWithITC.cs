using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionCheckWithITC : MonoBehaviour
{
    public Text _textPickUpInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        ItemTypeComponent itc = collision.gameObject.GetComponent<ItemTypeComponent>();

        if (itc != null)
        {
            switch (itc.Type)
            {
                case ItemType.SPHERE_DROP_ITEM:
                    _textPickUpInfo.text = "SPHERE_DROP_ITEM has been picked up";
                    break;
                case ItemType.CUBE_OBSTACLE:
                    _textPickUpInfo.text = " CUBE_OBSTACLE has been picked up";
                    break;
                case ItemType.CAPSULE_OBSTACLE:
                    _textPickUpInfo.text = "CAPSULE_OBSTACLE has been picked up";
                    break;
                case ItemType.CYLINDER_OBSTACLE:
                    _textPickUpInfo.text = "CYLINDER_OBSTACLE has been picked up";
                    break;
                case ItemType.GG_OBSTACLE:
                    _textPickUpInfo.text = "GG_OBSTACLE has been picked up";
                    break;
                case ItemType.TT_OBSTACLE:
                    _textPickUpInfo.text = "TT_OBSTACLE has been picked up";
                    break;
            }
        }
    }
}
