
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
        outPut += position.Y switch
        {
            0 => "A",
            1 => "B",
            2 => "C",
            3 => "D",
            4 => "E",
            5 => "F",
            6 => "G",
            7 => "H",
            _ => "",
        };

        outPut += position.X switch
        {
            0 => "1",
            1 => "2",
            2 => "3",
            3 => "4",
            4 => "5",
            5 => "6",
            6 => "7",
            7 => "8",
            _ => "",
        };

        X = position.X;
        Y = position.Y;

        return outPut;
    }
}