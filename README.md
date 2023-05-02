# GameEngines2Assignment2023

The project involves a series of slime creatures that are able to evolve and interact with eachother in a procedurally generated map 
using state machine behaviours.The creatures start as small spheres that can grow and change shape depending on user interaction.
The player is able to drop food into the map by using the mouse, this will create a food pellet that the creatures will seek and eat.
Once a creature eats a food pellet they lock in their mutation depending on which food they ate, the possible mutations are:

+ bipedal
+ quadrupedal
+ serpentine (snake-like)

This will affect their model and their behaviour towards eachother, some seing the other as friends or enemies. While the player have a say in what the
creatures become, they have no control over them nor they can change their behaviours once they grow up and mutate, what they do 
controll however is the amount of food to give a specific creature:When a creature eats enough food they create a second creature that
starts without mutations, this is used to simulate the creation of life and to try and keep the population balanced.

while the simulation of life is a complex study, enormous progress is being made by simulating aspects of it, this project focusses
on the social aspect of evolution and how it affects the relationships of the creatures that are being simulated: While they start as the same
they quickly separate in different categories and tend to group up with others of their kind.


ON THE MAP:
for the procedural generation of the map we used code to generate a mesh with a variable x and z size and we used perlin noise to smoothly alter the y values of the vertices, this way creating slopes and hills to simulate a terrain. We then proceded to add a falloff map to make the shape of the terrain look like an island, this process in particular was difficult to "tune" but it worked out in the end. For the generation of structures like trees and rocks we divided the max height of the map in 4 segments and checked which vertex filled the criteria (their y value) for the spawning of the objects: we check the vertex number x and see in what criteria it is, let's take for example Y level 2, we check the list of all the structures and see if there are structures that can spawn at y level 2, if there are we check their probability to spawn (percentage) and we roll a die, if it is under the probability it means that it can spawn, and a copoy of the object gets instantiated at those coordinates.
This system in particolar is very usefull because adding structures to the list is fairly easy and simple.
Some structures might need to be spawned only once, for that we have added a boolean in the structure details to check if the object needs to be only spawned in once

# Project Title

Name:

Student Number: 

Class Group:

Name: Kellie Meagher

Student Number: C20454772

Class Group: Game Design 

Name: Gabriele Lenzi

Student Number: C20743749

Class Group: Game Design

Include all team members names and student numbers if a team project

# Description

The project involves a series of slime creatures that are able to evolve and interact with eachother in a procedurally generated map 
using state machine behaviours. The creatures start as small spheres that can grow and change shape depending on user interaction.
The player is able to drop food into the map by using the mouse, this will create a food pellet that the creatures will seek and eat.
Once a creature eats a food pellet they lock in their mutation depending on which food they ate, the possible mutations are:

+ bipedal
+ quadrupedal
+ serpentine (snake-like)

This will affect their model and their behaviour towards eachother, some seing the other as friends or enemies. 

While the simulation of life is a complex study, enormous progress is being made by simulating aspects of it, this project focusses
on the social aspect of evolution and how it affects the relationships of the creatures that are being simulated: While they start as the same
they quickly separate in different categories and tend to group up with others of their kind.

## Video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

## Screenshots

# Instructions
WASD to move the camera position
SPACE and LEFT SHIFT to move on the Y axis
LEFT CLICK to spawn food in the target location
RIGHT CLICK to cycle trough the food types

While the player have a say in what thecreatures become, they have no control over them nor they can change their behaviours once they grow up and mutate, what they do controll however is the amount of food to give a specific creature:When a creature eats enough food they create a second creature thatstarts without mutations, this is used to simulate the creation of life and to try and keep the population balanced.

# How it works

+ map generation: For the procedural generation of the map we used code to generate a mesh with a variable x and z size and we used perlin noise to smoothly alter the y values of the vertices, this way creating slopes and hills to simulate a terrain. We then proceded to add a falloff map to make the shape of the terrain look like an island, this process in particular was difficult to "tune" but it worked out in the end. For the generation of structures like trees and rocks we divided the max height of the map in 4 segments and checked which vertex filled the criteria (their y value) for the spawning of the objects: we check the vertex number x and see in what criteria it is, let's take for example Y level 2, we check the list of all the structures and see if there are structures that can spawn at y level 2, if there are we check their probability to spawn (percentage) and we roll a die, if it is under the probability it means that it can spawn, and a copoy of the object gets instantiated at those coordinates.
This system in particolar is very usefull because adding structures to the list is fairly easy and simple.
Some structures might need to be spawned only once, for that we have added a boolean in the structure details to check if the object needs to be only spawned in once

+ Evolution: Each slimes evolution is determined by its State Machine. There are 3 States that dettermine the slimes evolutionary path:
  Bipedal, Quadrapedel and Serpintine. The way in which the slimes evolve is based on which food they eat first, further mutations occur then based on how much of each   type of food the slime has eaten, with different combinations leading to different result. With some altering the order in which the mutations emerge. The additional   limbs were animated with the unity animation system, The different limbs animations being played from different animation layers within the animation controller. The   State machine is made up of Base State (SlimeBaseState.cs) which stores the override classes, A state manager that holds references to the other state scripts and     manages the switching between states (FoodsStates.cs) and then the states themselves. A basic state (StartState.cs) which is simply an idle animation in the start     method with the update method then being used to determine which of the other states the slime will evolve into. Those being Bipedal (Humanoid.cs), Quadrapedal      (QuadState.cs) and Serpintine (SnakeState.cs). Each slime then has its own log of how many of each food type it has eaten which is stored as a float, each state then specifically calls the slimes state script (SlimeStats.cs) and will alter the slimes shape depending on how many of each has been eaten and in what order through a series of else if statements.
 

+

# List of classes/assets

| Class/asset | Source |
|-----------|-----------|
| createTree.cs | Self written |
| foodspawner.cs | Self written |
| generateLeafs.cs | Self written |
| generateStructures.cs | Self written |
| hidemouse.cs | Self written |
| maptest.cs | Self written except for the [falloff map](https://youtu.be/DBjd7NHMgOE?t=84) |
| movecam.cs | Self written |
| hidemouse.cs | Self written |
| randomrotation.cs | Self written |
| slowUpDown.cs | Self written |
| SpawnDetails.cs | Self written |
| waves.cs | Self written |
| treetest | Self Made using Probuilder |
| gazebocenter | Self Made using Probuilder |
| boulderset 1,2,3 | Self Made using Probuilder |
| invwall.cs | Self Made |
| spawnlocation.cs | Self Made using Probuilder |
| terrainshader.cs | followed this [video](https://www.youtube.com/watch?v=lNyZ9K71Vhc&t)|
| Cel Shader | [Reference](https://www.youtube.com/watch?v=lUmRJRrZfGc)|
| Blit.cs | [Reference][(https://github.com/Cyanilux/URP_BlitRenderFeature)]|
| FoodEffectOne.cs | Self Written |
| FoodTwoEffect.cs | Self Written |
| FoodEffectThree.cs | Self Written |
| FoodStates.cs| SlimeBaseState.cs |[Reference] [(https://youtu.be/Vt8aZDPzRjI)]|
| SlimeChanges.cs | Self Written |
| Humanoid.cs | Paritally Self Written with |[Reference] [(https://youtu.be/Vt8aZDPzRjI)]|
| QuadState.cs | Paritally Self Written with |[Reference] [(https://youtu.be/Vt8aZDPzRjI)]|
| StartState.cs | Paritally Self Written with |[Reference] [(https://youtu.be/Vt8aZDPzRjI)]|
| SnakeState.cs | Paritally Self Written with |[Reference] [(https://youtu.be/Vt8aZDPzRjI)]|
| ShowStats.cs | Self Written |
| Spawner.cs | Self Written |
| SlimeChanges.cs | Self Written |
| JellieMan.cs |  |



Each team member or individual needs to write a paragraph or two explaining what they contributed to the project

- What they did
- What they are most proud of
- What they learned

# Gabriele Lenzi:

+ i worked on the procedurally generated map, the structure spawning and the player controls. I did follow some videos about procedural mesh generation but i didn't use any of the code that they made

+ It was the first time trying procedural map generation and altough it looks very basic and not fully clean i'm really proud of how it turned out, i would have loved to work more and understand better how falloff maps worked. I don't like making "case-tailored" scripts, so making a structure script that can be used multiple times and that can be easily expanded upon was really important for me, i'm happy to say that it turned out pretty great

+ mostly how to work with meshes effectivly and their potential in the coding part of unity

# References
* Map Generation[1](https://youtu.be/DBjd7NHMgOE?t) & [2](https://www.youtube.com/watch?v=64NblGkAabk)
* [Vertex Coloring](https://www.youtube.com/watch?v=lNyZ9K71Vhc&t)
* 


