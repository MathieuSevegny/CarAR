using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// Dit au controlleur de jeu quel voiture est activé
    /// </summary>
    public void Detecte()
    {
        Controlleur.Instance.vehicule = this;
    }
    /// <summary>
    /// Déplace la voiture.
    /// </summary>
    /// <param name="deplacement">1 -> avancer, -1 reculer ou 0 -> rien</param>
    /// <param name="rotation">1 -> droite, -1 gauche ou 0 -> rien</param>
    public void Deplacer(float deplacement, float rotation)
    {
        gameObject.transform.Rotate(new Vector3(0, rotation,0) * 5);
        gameObject.transform.Translate(new Vector3(deplacement, 0, 0)/10);
    }
}
