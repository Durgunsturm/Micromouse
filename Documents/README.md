# Micromouse

For design structure these programs could be separated into different files, and then shifted to one large file when uploaded

# Programs need to complete these tasks:

- Scanning maze:
    - For scanning, routes closer to the start are more likely to be included in the shortest path, so are more 'valuable' to have scanned.
      Conversely, routes further away from the start (like at the opposite corner of the maze) are unlikely to be in the route so are unnecessary.
    - Also a straight route is faster for the robot than a curved route for the same distance
    - Needs to be able to navigate maze using one of:
        - Left hug
            - Very simple

            - Will scan a lot of less valuable routes
            - Will get stuck if there's an uninterrupted loop (like a loop on the outside)      <-- This is really bad
        - Breadth-first search
            - Will scan the most valuable routes
            - Can route down faster routes

            - Frequent backtracking could slow down mapping if goal is too far into the maze
            - Will have to implement a certain depth traversed before backtracking (otherwise its always backtracking)
        - Depth-first search
            - Can route down faster routes

            - Will scan a lot of less valuable routes

    - Take distance readings and translate them into a movement vector
        - Use that vector to calculate coordinate pathing?
    - Pause when end goal is reached
        - Work out how to recognise end point

- Calculating shortest path:
    - Potential Algorithms:
        - Dijkstra's
        - A*

- Moving along dedicated path:
    - Either:
        - Convert distance mappings into motion using timers
        - Use sensor readings to learn position in maze and execute next movement


# Programs:

- Mapper
    - Maps through the whole maze (or at least as much as it can)

- Translator
    - Converts from distance readings to coordinates

- Shortest Path
    - Finds the shortest path through a maze

- Racer
    - Gets to the goal as fast as possible