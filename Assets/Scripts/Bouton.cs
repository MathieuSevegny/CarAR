using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum Touche
{
    Avancer,
    Reculer,
    Gauche,
    Droite
}

public class Bouton : MonoBehaviour
{
    public Touche touche;
    public bool isPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            Controlleur.Instance.Deplacer(touche);
        }
    }
    /// <summary>
    /// Déplace la voiture
    /// </summary>
    public void Deplacer()
    {
        Controlleur.Instance.Deplacer(touche);
    }

    public void OnPointerDown()
    {
        isPressed = true;
    }
    public void OnPointerUp()
    {
        isPressed = false;
    }
}
