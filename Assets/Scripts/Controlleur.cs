using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlleur : MonoBehaviour
{
    public static Controlleur Instance;
    public Vehicule vehicule;
    public float vitesse;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    /// <summary>
    /// Déplace le véhicule
    /// </summary>
    /// <param name="touche">Touche cliqué</param>
    public void Deplacer(Touche touche)
    {
        if (vehicule == null) return;

        var delta = Time.deltaTime;

        switch (touche)
        {
            case Touche.Avancer:
                vehicule.Deplacer(1* delta * vitesse, 0);
                break;
            case Touche.Reculer:
                vehicule.Deplacer(-1 * delta * vitesse, 0);
                break;
            case Touche.Gauche:
                vehicule.Deplacer(0, -1 * delta * vitesse * 3);
                break;
            case Touche.Droite:
                vehicule.Deplacer(0, 1 * delta * vitesse * 3);
                break;
        }
        
    }
}
