using System.Xml.Linq;
using static System.Console;

Exercise1(6, '#');

Write(Exercise2(1221));
void Exercise1(int side, char symbol)
{
    for(int i = 0;i < side; i++)
    {
        for (int j = 0; j < side; j++)
        {
            Write(symbol + " ");
        }
        WriteLine();
    }
}

bool Exercise2(int numberUser)
{
    string number = numberUser.ToString();
    string reverseNumber = new string(number.Reverse().ToArray());

    if (number == reverseNumber)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] Exercise3(int[] mas, int[] ArrayWithFilter)
{
    int i = 0;
    int[] masReturn = new int[mas.Length - ArrayWithFilter.Length];

    foreach (var item1 in mas)
    {
        foreach (var item2 in ArrayWithFilter)
        {
            if(item1 != item2)
            {
                masReturn[i] = item1;
                i++;
            }
        }
    }

    return masReturn;
}

class Website
{
    private string? _name, _path, _description;
    private int _ip;
    public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string? Path
    {
        get { return _path; }
        set { _path = value; }
    }
    public string? Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Ip
    {
        get { return _ip; }
        set { _ip = value; }
    }

}

class Magazine
{
    private string _name, _description, _phone, _mail;
    private int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    public string Mail
    {
        get { return _mail; }
        set { _mail = value; }
    }
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}

class Shop
{
    private string _name, _description, _phone, _mail, _address;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    public string Mail
    {
        get { return _mail; }
        set { _mail = value; }
    }
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
}