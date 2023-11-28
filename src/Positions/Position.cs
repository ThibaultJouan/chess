
class Position
{
    public int x;
    public int y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Position(string input)
    {
        SetPosition(input);
    }

    public void SetPosition(Position position)
    {
        this.x = position.x;
        this.y = position.y;
    }

    public void SetPosition(string input)
    {
        switch(input[0])
        {
            case 'A':
                this.y = 0;
                break;
            case 'B':
                this.y = 1;
                break;
            case 'C':
                this.y = 2;
                break;
            case 'D':
                this.y = 3;
                break;
            case 'E':
                this.y = 4;
                break;
            case 'F':
                this.y = 5;
                break;
            case 'G':
                this.y = 6;
                break;
            case 'H':
                this.y = 7;
                break;
            default :
                this.y = -1;
                break;
        }

        switch(input[1])
        {
            case '1':
                this.x = 0;
                break;
            case '2':
                this.x = 1;
                break;
            case '3':
                this.x = 2;
                break;
            case '4':
                this.x = 3;
                break;
            case '5':
                this.x = 4;
                break;
            case '6':
                this.x = 5;
                break;
            case '7':
                this.x = 6;
                break;
            case '8':
                this.x = 7;
                break;
            default :
                this.x = -1;
                break;
        }
    }

    public string GetPosition(Position position)
    {
        string outPut = "";
        switch(position.y)
        {
            case 0:
                outPut += "A";
                break;
            case 1:
                outPut += "B";
                break;
            case 2:
                outPut += "C";
                break;
            case 3:
                outPut += "D";
                break;
            case 4:
                outPut += "E";
                break;
            case 5:
                outPut += "F";
                break;
            case 6:
                outPut += "G";
                break;
            case 7:
                outPut += "H";
                break;
            default :
                outPut = "";
                break;
        }

        switch(position.x)
        {
            case 0:
                outPut += "1";
                break;
            case 1:
                outPut += "2";
                break;
            case 2:
                outPut += "3";
                break;
            case 3:
                outPut += "4";
                break;
            case 4:
                outPut += "5";
                break;
            case 5:
                outPut += "6";
                break;
            case 6:
                outPut += "7";
                break;
            case 7:
                outPut += "8";
                break;
            default :
                outPut = "";
                break;
        }
        this.x = position.x;
        this.y = position.y;

        return outPut;
    }


}