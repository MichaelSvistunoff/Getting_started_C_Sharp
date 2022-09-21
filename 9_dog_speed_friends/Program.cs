int count = 0;                                              // Initial counter
int distance = 10000;                                       // Initial distance
int firstFriendSpeed = 1;                                   // Initial speedFriend1
int secondFriendSpeed = 2;                                  // Initial speedFriend2
int dogSpeed = 5;                                           // Initial dogSpeed
int friend = 2;                                             // Initial friend
int time = 0;                                               // Initial time


while ( distance > 10 ) {                                   // Do while your distance more than 10    
    if ( friend == 1 ) {                                    // Friend = 1
        time = distance / ( firstFriendSpeed + dogSpeed );
        friend = 2;
    }    
    else {                                                  // Friend = 2
        time = distance / ( secondFriendSpeed + dogSpeed );
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine("Собака пробежала " + count + " раз");    // Show me how many times the dog was runing between 2 friends