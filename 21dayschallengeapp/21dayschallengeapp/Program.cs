var name = "Ewa";
var sex = "Woman";
var age = 30;

if (sex == "Woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}
else if (sex == "Man" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Żadna z powyższych odpowiedzi");
}