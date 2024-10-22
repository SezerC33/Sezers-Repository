using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class WeeklyPlan : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        // Array for days of the week
        string[] weeklyplan = new string[] { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "L�rdag", "S�ndag" };

        // "for" Loop applied to string. 
        for (int i = 0; weeklyplan.Length > i; i++)
        {
            // Using switch statements "cases" to organize outcomes of conditions
            switch (weeklyplan[i])
            {
                case "Mandag":
                    Debug.Log("Arbejde med gruppe");
                    break;

                case "Tirsdag":
                    Debug.Log("Forl�sning");
                    break;

                case "Onsdag":
                    Debug.Log("PBL Kursus");
                    break;

                case "Torsdag":
                    Debug.Log("IKDU Kursus");
                    break;

                case "Fredag":
                    Debug.Log("L�se op p� programmering");
                    break;

                case "L�rdag":
                    Debug.Log("Arbejde");
                    break;

                case "S�ndag":
                    Debug.Log("Afslapning");
                    break;


                default:
                    Debug.Log("????");
                    break;

            }
        }


        Schedule();
    }
    // Create new void
    private void Schedule()
    {
        // Array for days of the week
        string[] day = new string[] { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "L�rdag", "S�ndag" };

        // Create a loop like previously
        for (int i = 0; day.Length > i; i++) {
            
            // If statement: If it is monday.
            if (day[i] == "Mandag")
            {
                // We work on semesterprojects in groups.
                Debug.Log("Semesterproject with group");
            }
            else if (day[i] == "Tirsdag")
            {
                Debug.Log("IKDU Course & Lesson recap/Study");
            }
            else if (day[i] == "Onsdag")
            {
                Debug.Log("PBL Course & Soccer practice");
            }
            else if (day[i] == "Torsdag")
            {
                Debug.Log("IKDU Course & Studying");
            }
            else if (day[i] == "Fredag")
            {
                Debug.Log("Semesterproject with group & Soccer practice");
            }
            else if (day[i] == "L�rdag")
            {
                Debug.Log("Work");
            }
            else if (day[i] == "S�ndag")
            {
                Debug.Log("Study & Preparing for next week");
            }

        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}

