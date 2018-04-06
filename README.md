# 50.003-Game

Cohort 2 Grp5

Game Play
Two players compete to collect the coins with button controllers. 
Buttons control movments are : left, right, dash and jump. Double jump is not allowed due to the size of the android phone is relatively small and to make the game more competitive as players will not collect the coin as easily.
There are two type of coin, the first type is the normal coin that worth 1 point. The second type is the special coin that only gets relesased when one player hit the spike. This kind of coin has different UI and is worth 2 points. Hence players can push their opponents to hit spikes to release such coin. All types of coin will show up at random locations for players to race to collect it. At any point of time, there will only be one coin of each type. 

Winning Condition:
The player that collects 20 coins first , wins. 

Contributions: 
Albert :Player movement, animations, UI display, Player movement testing on NUNIT.
Needs to add: coin Collisions, coin spawn testing, location of coin spawn testing, spike testing,misuse cases testings.

Candace: Player-coin Collison, Player-Spike Collision, Updating points, Respawning coin after collision
Needs to add: a restrictive box to prevent the coin from appearing behind the coin or outside of the scene box.

Yuxuan: UI background images. 

Yanbo: Player spawning,movement synchching, identify local player, coin spawning , updating scores across the network
Needs to add: fix the coin not appearing for both players properly, spikes network collision, andriod phone network, fix the random location not working in the it should as written in the code.

