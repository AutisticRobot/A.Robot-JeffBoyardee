using Godot;
using System;

public class ai : Node
{

//constructor
public ai()
{

}

public Vector2 findValidPos(Vector2 pos, float range)
{
    //testing values
    //Vector2 pos = new Vector2(100,100);
    //float range = 250;

    Vector2 tar;
    float dis;
    bool isValid = false;
    int maxLoop = 5;
    
    do
    {
        
        tar = new Vector2(0,0);
        dis = (float)GD.RandRange(0,range);
        tar.x = (float)GD.RandRange(-1,1);
        tar.y = (float)GD.RandRange(-1,1);
        tar *= dis;
        tar += pos;
        isValid = ( 0 <= tar.x && tar.x <= 1920 );
        isValid = (isValid && 0 <= tar.y && tar.y <= 1080);
        maxLoop--;
    } while (!isValid && maxLoop > 0);

    if(isValid)
    {
        return tar;
    }else{
        return pos;
    }
}
}
