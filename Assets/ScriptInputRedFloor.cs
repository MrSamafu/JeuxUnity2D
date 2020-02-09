using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInputRedFloor : MonoBehaviour
{
    public GameObject leSol;//variable public qui permet d'assigner un gameObject ingame directement dedans, ici floor est dans sol.

    // Start is called before the first frame update
    void Start()//fonction qui se lance au debut du script
    {
        
    }

    // Update is called once per frame
    void Update()//fonction qui se joue a chaque frames du jeux
    {
        RaycastHit hit;//variable du raycast
        if (Input.GetMouseButtonDown(0))//condotion qui est réaliser par un clic souris
        {
            leSol.GetComponent<Renderer>().material.color = Color.red;//change la couleur du sol en rouge
            Debug.DrawRay(transform.position, transform.right * 5, Color.red);//affiche le trajet du raycast, fonction debug visible par le dev seulement
            if (Physics.Raycast(transform.position,transform.right,out hit, 5))//condition qui détermine si le raycast touche qqchose ou non
            {
                
                Destroy(hit.transform.gameObject);//detruit l'objet toucher par hit
            }
        }
        

       

        
    }

    void OnTriggerStay()//Réalise une action lorsque $this entre dans un objet avec le dit objet, ici le sol
    {
        leSol.GetComponent<Renderer>().material.color = Color.blue;//Change la couleur du sol en bleu lorsque le sol est touché par $this
        
    }
}
