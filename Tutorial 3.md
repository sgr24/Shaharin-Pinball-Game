# Pinball Game Tutorial

I used the template from https://www.youtube.com/watch?v=HObTp3JM_Qw

## 3. Making Bouncers and making it functional

Insert a corner piece on your board opposite the spring since that is where the ball will hit to go deeper into the board and allow the game to function properly

To create a couple of bouncers;
- Click game object --> 3D object --> cylinder or any other object you want to have as a bouncer

Set the piece close to the board floor and duplicate it to make a couple of the objects & scatter the objects around on the board to make the game a little bit more interesting and fun to play

For the object to be bouncy, we will write a script where the collision from the ball to the bouncer will exert an explosion-like movement, making it look like it bounces off the object

,,,

    using UnityEngine;

    public class BounceObject : MonoBehaviour
    {
        public float explosionStrength = 100;

        void OnCollisionEnter(Collision _other)
        {
            _other.rigidbody.AddExplosionForce(explosionStrength, this.transform.position, 5);
        }
    }

,,,

At the moment, the public class is set to the default digit of 100, but we will be able to change that through the inspector tab since this piece of code is made to be able to be edited publicly

Going back to the inspector tab, head to bounce object public script, edit the explosion strength and set the figure to 1500 or higher or lower depending on how bouncy you want the game objects to be

Place the bouncers in a fixed position where you know it will hit but have a low possibility of going back into the spring lane
