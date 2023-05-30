using Godot;
using System;

public class ai : Node
{
    //Sprite mainBody;
    public Vector2 pos;


//constructor
public ai()//simply passing in each varrible individualy until i Find a better sulution( even if it is only in other games)
{
    //this.pos = pos;//none is set in constuctor for now.
    //this.mainBody = mainBody;
}


public Vector2 findValidPos(){return this.findValidPos(100);}
public Vector2 findValidPos(float range)
{

    //Vector2 pos = mainBody.Position;
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

public Vector2 walkToVec(Vector2 target)
{
    Vector2 velocity;
    velocity = target - pos;//mainBody.Position;
    return velocity;
}

public bool checkOverlap(Vector2 pos, Vector2 target, Vector2 range)
{
    bool xOverlap = false;
    bool yOverlap = false;

    if(pos.x - target.x <= range.x && target.x - pos.x <= range.x)
    {
        xOverlap = true;
    }
    if(pos.y - target.y <= range.y && target.y - pos.y <= range.y)
    {
        yOverlap = true;
    }

    if(xOverlap && yOverlap)
    {
        return true;
    }else{
        return false;
    }

}


}
