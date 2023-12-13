
class Position
{
    public int X;
    public int Y;

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Position(string input)
    {
        SetPosition(input);
    }

    public void SetPosition(Position position)
    {
        X = position.X;
        Y = position.Y;
    }

    public void SetPosition(string input)
    {
        Y = input[0] switch
        {
            'a' => 0,
            'b' => 1,
            'c' => 2,
            'd' => 3,
            'e' => 4,
            'f' => 5,
            'g' => 6,
            'h' => 7,
            _ => -1,
        };
        X = input[1] switch
        {
            '1' => 0,
            '2' => 1,
            '3' => 2,
            '4' => 3,
            '5' => 4,
            '6' => 5,
            '7' => 6,
            '8' => 7,
            _ => -1,
        };
    }

    public string GetPosition(Position position)
    {
        string outPut = "";
        switch(position.Y)
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

        switch(position.X)
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
        X = position.X;
        Y = position.Y;

        return outPut;
    }
}