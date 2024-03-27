using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TP : MonoBehaviour
{
    public GameObject Joueur;
    public GameObject TPJOUEURPOS;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider ColliderTP)
    {
        if (ColliderTP.gameObject.CompareTag("Player"))
        {
            Debug.Log(ColliderTP.name);
            CharacterController _Controller = ColliderTP.GetComponent<CharacterController>();
            _Controller.enabled = false;
            ColliderTP.transform.position = TPJOUEURPOS.transform.position;
            _Controller.enabled = true;
            //SceneManager.LoadScene(fERNANDEZrOMAIN);

        }

    }
}
