# GameEngines2Assignment2023

the project involves a serie of slime creatures that are able to evolve and interact with eachother in a procedurally generated map 
using a list of behaviours. While the creatures does start as smal spheres they can grow up and change shape depending on user interaction:
the player is able to drop food into the map by using the mouse, this will create a food pellet that the creatures will seek and eat.
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
