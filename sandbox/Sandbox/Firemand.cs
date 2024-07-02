class Fireman : Person
{

private string _certifications;

Fireman (string certification, string f, string l, int a, int w): base (f,l,a,w)
{
    _certifications= certification;
}

public string FiremanInformation()
{
    return$"{_certifications}, {PersonInformation()}";
}


}