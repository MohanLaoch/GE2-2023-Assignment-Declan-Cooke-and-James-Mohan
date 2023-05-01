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
When designing the rules and behaviours of our aquatic creaetures we kept in mind a system that could keep them always evolving and adapting to new challenges and opportunities. Each time the scene is started a random followpath is created for the anglerfish boid and the turtles, this means that each new instance of the scene provided these followpath creatures with new obstacles to avoid. To make sure that this happens smoothly both the angerfish and the turtles have the avoidance behaviour with it set to avoid obstacles and the player. In addition to this, the shark boid will chase the fish boids. After a set time of not being able to catch these fish, the shark will change target, adapting their path to the new target they are following.
