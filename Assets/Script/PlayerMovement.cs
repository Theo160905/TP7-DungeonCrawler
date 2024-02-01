using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    CharacterController ch;

    public float movespeed;
    public int PointsDeVie;
    public int Degats;

    public PlayerMovement(float ms, int pv, int att)
    {
        movespeed = ms;
        PointsDeVie = pv;
        Degats = att;
    }

    void Start()
    {
        ch = GetComponent<CharacterController>();
        PlayerMovement bob = new(10f, 50, 5);
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float x = Input.GetAxis("Horizontal") * movespeed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        var dir = new Vector3(x, y, 0);
        ch.Move(dir);
    }

}