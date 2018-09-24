Lightshot Game
======

###BUILD INSTRUCTIONS
1. Import the project into your Unity Editor (2017.02.0f3 >)
2. Open the project, then select `File > Build Settings`
3. Ensure that the `MainScene` is added to the build steps by clicking `Add Open Scenes`.
4. Select `PC, Mac, and Linux Standalone`.
5. Press `Build and Run`. 


###CONTROLS
* Movement controls are done using W-A-S-D configuration.
* Aiming can be done with either the mouse or arrow keys.
* Left click or spacebar will shoot Light from the gun.
* Change your Light by pressing the numbers 1, 2, 3, 4, or 5 on the Number Row.


###GAME MECHANICS
The game will continually spawn LightTargets above the play area. Using your gun,
shoot the targets with the corresponding colour in order to earn a point. There is no
time limit or punishment for falling behind - use the game to increase coordination
and spacial reasoning. The bullets can be hard to judge as they're invisible in the air
without a reflective surface!


============================================


#####Musings

Long development time for me on this project while switching context from web-based development.
Working in the Unity Editor had challenges that only reading, studying, and iterating could 
teach. I'm happy to say that I feel a lot more fluent than I did before with both the editor
and C# as a whole - but the biggest gain was probably understanding much of what Unity's opinions
are on optimal nesting and relationship between components (such as transforms for nesting, 
monobehaviours as coroutines, and more). 

Testing was a bit of a fall-down here, as the monobehaviours polluted too much of my code
and made testing hard. I wasn't sure how to fix this eloquently and made an attempt - this 
will be a big area for me to learn to improve in future work for desiging better OO code in 
Unity that plays well with its opinons. 

