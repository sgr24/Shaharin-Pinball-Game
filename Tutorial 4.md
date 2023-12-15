# Pinball Game Tutorial

I used the template from https://www.youtube.com/watch?v=HObTp3JM_Qw

## 3. Making Out Of Bounds Border and making it funcitonal

Start of by placing a cube in the scene;
- Game Object --> 3D object --> Cube

Resize the cube to cover the whole lenght if not slightly wider than the whole pinball board and make it longer in order to create the border

Re-position the Main Camera so it does not show the cube that you have just made, since the only purpose of the cube that you have created was to detect the ball if it goes off the board, make sure that the camera only shows the main board instead of the board as well as the cube that you have made

The code that will detect when the ball goes out of bounds will have 2 features:

First one detects the velocity of the ball;

