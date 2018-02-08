using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField]
    private GameObject _case;

	// Use this for initialization
	void Start () {

        Carte c = new Carte();
        Vector2 sizeSprite = _case.GetComponent<Renderer>().bounds.size;
        Quaternion spawnRotation = Quaternion.identity;
        for (int i = 0; i < c.Largeur; i++)
        {
            for (int j = 0; j < c.Longueur; j++)
            {
                float x = 0;
                float y = 0;
                x = (j * sizeSprite.x * 3) / 4;

                if (j % 2 == 0)
                    y = -(i * sizeSprite.y);
                else
                    y = -(i * sizeSprite.y + sizeSprite.y/2);

                Vector2 spawnPosition = new Vector2(x, y);
                Instantiate(_case, spawnPosition, spawnRotation);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {

	}
}
