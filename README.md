# GE2-2023-Assignment-Declan-Cooke-and-James-Mohan

# The Ocean Experience

### Names & Student Numbers:
#### Declan Cooke | C20465442
#### James Mohan | C20305011

### Video: 
(To be added)

# Proposal
We plan on making a simulation of marine life living in their natural habitat underwater. Marine life is incredibly diverse and complex, with countless species exhibiting a wide range of behaviours that allow them to survive and thrive in their environments. Throughout our project we will explore the use of emergent behaviour, boids, harmonic functions, perlin noise, and a wide range of autonomous behaviours to simulate many different creatures working together in harmony. The environment around the sea creatures will provide new challenges and opportunities that they must adapt to. The simulation will provide a dynamic representation of a marine ecosystem, where many different creatures interact with each other in a complex and harmonious way.

### The Approach
Through simple behaviours and algorithms, we wanted to simulate an aquarium teeming with life that interacts with eachother in a multitude of ways. We made a wide range of different types of fish and aquatic life with simple instructions and states. 


### Alan Watts
While our aquatic creatures only have a simple set of behaviours, what emerges from them interacting with one another is an explosion of autonomous life and individuality neither of us had predicted when we created this project. A school of fish with that follows a leader fish will flee in a wonderful unique pattern when its encountered by the shark boid, the pattern in which the fish flee is different every time. In an attempt to keep the creatures within the boundary of the scene, we added a simple avoidance algorithm to our creatures, and programmed them to avoid the walls of our scene. This simple instruction led to emergent patterns and behaviours in how the creatures would act when approaching the boundaries. They would fly in unpredicatble directions every time, especially the schools of fish. This would create situations where the shark boid would reach the wall chasing a fish and wouldn't know what to do, causing the shark boid to wait for the fish to turn around for  its chance to eat the poor fish! 

### Terence McKenna
When designing the rules and behaviours of our aquatic creatures we kept in mind a system that could keep them always evolving and adapting to new challenges and opportunities. Each time the scene is started a random followpath is created for the anglerfish boid and the turtles, this means that each new instance of the scene provided these followpath creatures with new obstacles to avoid. To make sure that this happens smoothly both the angerfish and the turtles have the avoidance behaviour with it set to avoid obstacles and the player. In addition to this, the shark boid will chase the fish boids. After a set time of not being able to catch these fish, the shark will change target, adapting their path to the new target they are following.

### Mathematics
By using the mathematical power of boids we were able to replicate the behaviour of aquatic creatures. Despite the entire scene being completely random, we noticed quickly that the schools of fish will often bunch together to avoid the shark. Exploring the world of chaos theory helps us understand this phenomenon.

### The Universe
Our world is an underwater environment. Thus our artificial life replicates the behaviour of aquatic creatures. When creating their systems we wanted the aquatic creatures to feel natural in their environment. To do this each boid has different behaviours that mirror the real life aquatic creature. Sharks have pursue behaviours, whereas fish have flee behaviours and the turtles have pathfollows that are random with each instance.


### Screenshots


### Instructions
WASD keys to move around the aquarium, spacebar to move up and shift to move down

### How it works
Explore the underwater environment and observe how the different creatures interact with one another.

### List of classes/assets
|StateMachine.cs |Modified from reference|
FishController.cs Modified from reference
Flee.cs Modified from reference
Wander.cs Modified from reference
SchoolingFish.cs Modified from reference
Boid.cs From reference
Avoidance.cs Modified from reference
FollowPath.cs Modified from reference
PlayerMovement.cs Self Written
SeaWeed.cs Self Written
Colourchange.cs Self Written
Harmonic.cs Modified from reference



Class/asset	Source
MyClass.cs	Self written
MyClass1.cs	Modified from reference
MyClass2.cs	From reference


Each team member or individual needs to write a paragraph or two explaining what they contributed to the project

What they did

What they are most proud of

What they learned

References
Item 1
Item 2


