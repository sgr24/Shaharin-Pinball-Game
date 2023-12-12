# Pinball Game Tutorial

I used this code from https://www.youtube.com/watch?v=gAlJN8VGo94 & https://www.youtube.com/watch?v=HObTp3JM_Qw

## 1. Making the paddle and getting it to work

Start by clicking game object --> Create empty

Please add the sprites you got from the net or created and put in the assets.

Then click on all the sprites on the right-hand side and see "Wrap mode." Change it from** "Clamp"** to **"Repeat"** and **"Filter mode"** change it to **point(no filter)**. 

Wrap mode determines how time is treated outside of the keyframed range of an AnimationClip or AnimationCurve.

Filter mode changes the filter of your pixel art depending on your game.

Still selected, unclick the ground sprite and change the under the **Default: Max size:** 2048 to 256 and the ground spite to 4096, then click apply. 

The default mode is the maximum size of your pixel art.

After that, drag the player sprite in an idle position and ground sprites onto the "Hierarchy." click on Player, add components, add in "Character Controller", and change the character's name to Player or something else.

Character controller allows you, the Player, to control the movements of the Player.

Underneath, you find "Tag." Change it to **"Player"** to let the game know this is the character you are moving or controlling. 

Then go on the ground and add a "Box collider".

A box collider is a collider that makes the game recognize that you crashed into something.

A tag in unity means giving a label to something and then calling it later in the script.
