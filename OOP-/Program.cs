using OOP_;
using static OOP_.Animal;
using static OOP_.Bird;
using static OOP_.Fish;
using static OOP_.Student;
using static OOP_.Person;
//using static OOP_.CommonCalc;
//using static OOP_.Factorial;

//Animal animal = new Animal();

//animal.name = "Canavar";


//Bird bird = new Bird();

//bird.name = "Qartal";

//Console.WriteLine(animal.name);

//Fish fish = new Fish();

//fish.Sound();

//bird.Sound();


//Factorial factorial = new Factorial();

//int result = factorial.GetFactorial(5);

//Console.WriteLine(factorial.GetCalc(5,6) + result);


//Bird bird = new Bird("qartal");



Student student = new Student();

student.name = "Nurlan";
student.surname = "Musayev";
student.age = 21;
student.address = "Qazax";

Console.WriteLine(student.GetFullData());