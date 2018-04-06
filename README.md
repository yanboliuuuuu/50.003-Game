# 50.003-Game

Cohort 2 Grp5

Here is our star game for the single player mode that we have already successfully built on the android phone. 

Game Play
Two players compete to collect the star with button controllers. 
Buttons control movments are : left, right, dash and jump. Double jump is not allowed due to the size of the android phone is relatively small and to make the game more competitive as players will not collect the stars as easily.
There are two type of stars, the first type is the normal star that worth 1 point. The second type is the special star that only gets relesased when one player hit the spike. This kind of star has different UI and is worth 2 points. Hence players can push their opponents to hit spikes to release such stars. All types of stars will show up at random locations for players to race to collect it. At any point of time, there will only be one star of each type. 

Contributions: 
Albert :Player movement, animations, UI display, Player movement testing on NUNIT.
Needs to add: Star Collisions and Spawning testing. Also misuse cases testings.

Candace: Player-Star Collison, Player-Spike Collision, Updating points, Respawning star after collision
Needs to add: a restrictive box to prevent the stars from appearing behind the star or outside of the scene box.

Yuxuan: UI background images. 

Yanbo: Player spawning,movement synchching, identify local player, star spawning , updating scores across the network
Needs to add: fix the star not appearing for both players properly, spikes network collision, andriod phone network, fix the random location not working in the it should as written in the code.

