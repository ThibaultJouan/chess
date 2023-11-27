using System;
using System.Runtime.CompilerServices;

class Position
{
    public int x;
    public int y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetPosition(string input)
    {
        switch(input[0])
        {
            case 'A':
                this.x = 0;
                break;
            case 'B':
                this.x = 1;
                break;
            case 'C':
                this.x = 2;
                break;
            case 'D':
                this.x = 3;
                break;
            case 'E':
                this.x = 4;
                break;
            case 'F':
                this.x = 5;
                break;
            case 'G':
                this.x = 6;
                break;
            case 'H':
                this.x = 7;
                break;
            default :
                this.x = -1;
                break;
        }

        switch(input[1])
        {
            case '0':
                this.x = 0;
                break;
            case '1':
                this.x = 1;
                break;
            case '2':
                this.x = 2;
                break;
            case '3':
                this.x = 3;
                break;
            case '4':
                this.x = 4;
                break;
            case '5':
                this.x = 5;
                break;
            case '6':
                this.x = 6;
                break;
            case '7':
                this.x = 7;
                break;
            default :
                this.x = -1;
                break;
        }
    }

    //TODO: setPosition : A2 => 0:2
    //TODO: getPosition : 0:2 => A2

}