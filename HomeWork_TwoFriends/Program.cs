double distance=1000, 
       firstFriendSpeed=1, 
       secondFriendSpeed=2, 
       dogSpeed=5;
double time=0; 
int count = 0; 
int friend=2;
while (distance>=1)
{
    if (friend==2)
    {
        time=distance/(secondFriendSpeed+dogSpeed);
        friend=1;
    }
    else 
    {
        time=distance/(firstFriendSpeed+dogSpeed);
        friend=2;
    }
    distance=distance-(firstFriendSpeed+secondFriendSpeed)*time;
    count++;
}
Console.WriteLine(count);