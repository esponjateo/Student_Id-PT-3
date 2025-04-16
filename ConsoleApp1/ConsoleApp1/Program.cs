using System;


namespace hallo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Put Student ID Number");
            string StudentInput = Console.ReadLine();

            

            if (!string.IsNullOrEmpty(StudentInput))
            {
                //Adora
                if (StudentInput == "24-668")
                {
                    Console.WriteLine("Student ID: 24-668 \nName: Adora, Christian Mateo Perez \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: June 17, 2007");
                }
                //Theo
                else if (StudentInput == "24-727")
                {
                    Console.WriteLine("Student ID: 24-727 \nName: Baja, Feliz Salazar \nAge: 18 \nGrade level: 11 \nSection: Python \nDay of Birth: March 5, 2007");
                }
                //Warleyne
                else if (StudentInput == "24-759")
                {
                    Console.WriteLine("Student ID: 24-759 \nName: Casanova, Warleyne Españo \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: January 22, 2008");
                }
                //Tristan
                else if (StudentInput == "24-665")
                {
                    Console.WriteLine("Student ID: 24-665 \nName: Dreslinski, Tristan Daniel Tabornal \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: December 21, 2007");
                }
                //Floyd
                else if (StudentInput == "24-756")
                {
                    Console.WriteLine("Student ID: 24-756 \nName: Escuadra, Floyd Francisco \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: December 19, 2007");
                }
                //JM
                else if (StudentInput == "24-744")
                {
                    Console.WriteLine("Student ID: 24-744 \nName: Esquivel, Jon Miguel Valeroso \nAge: 16 \nGrade level: 11 \nSection: Python \nDay of Birth: June 28, 2008");
                }
                //Ari
                else if (StudentInput == "24-677")
                {
                    Console.WriteLine("Student ID: 24-677 \nName: Galo, Ariane Ignacio \nAge: 20 \nGrade level: 11 \nSection: Python \nDay of Birth: September 21, 2004");
                }
                //Jah-Rek
                else if (StudentInput == "24-781")
                {
                    Console.WriteLine("Student ID: 24-781 \nName: Gayod, Jah-Rek Romeus \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: July 19, 2007");
                }
                //George
                else if (StudentInput == "24-777")
                {
                    Console.WriteLine("Student ID: 24-777 \nName: George, Michael Sarad \nAge: 20 \nGrade level: 11 \nSection: Python \nDay of Birth: September 29, 2004");
                }
                //John
                else if (StudentInput == "24-731")
                {
                    Console.WriteLine("Student ID: 24-731 \nName: Inez, Juan Miguel Loro \nAge: 18 \nGrade level: 11 \nSection: Python \nDay of Birth: April 10, 2007");
                }
                //Jared
                else if (StudentInput == "24-664")
                {
                    Console.WriteLine("Student ID: 24-664 \nName: Isidoro, Jared Carlo Garcia \nAge: 18 \nGrade level: 11 \nSection: Python \nDay of Birth: February 16, 2007");
                }
                //Jedi
                else if (StudentInput == "24-776")
                {
                    Console.WriteLine("Student ID: 24-776 \nName: Lopez, Jedidiah Hubbard \nAge: 18 \nGrade level: 11 \nSection: Python \nDay of Birth: October 20, 2006");
                }
                //Arjan
                else if (StudentInput == "24-752")
                {
                    Console.WriteLine("Student ID: 24-752 \nName: Manzano, Arjan Jhames Alpas \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: October 12, 2007");
                }
                //Brylle
                else if (StudentInput == "24-739")
                {
                    Console.WriteLine("Student ID: 24-739 \nName: Matias, Brylle Christian Serrano \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: November 6, 2007");
                }
                //Mikel
                else if (StudentInput == "24-716")
                {
                    Console.WriteLine("Student ID: 24-716 \nName: Ramos, Mikel Reuel Gaudia \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: November 11, 2007");
                }
                //Isaiah
                else if (StudentInput == "24-748")
                {
                    Console.WriteLine("Student ID: 24-748 \nName: See, Isaiah Will So \nAge: 16 \nGrade level: 11 \nSection: Python \nDay of Birth: February 24, 2009");
                }
                //Andrei
                else if (StudentInput == "24-669")
                {
                    Console.WriteLine("Student ID: 24-669 \nName: Siruno, Andrei Bautista \nAge: 16 \nGrade level: 11 \nSection: Python \nDay of Birth: July 3, 2008");
                }
                //Marcus
                else if (StudentInput == "24-743")
                {
                    Console.WriteLine("Student ID: 24743 \nName: Ureta, Marcus Timothy Thalla \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: October 28, 2007");
                }
                //Enzo
                else if (StudentInput == "24-682")
                {
                    Console.WriteLine("Student ID: 24-682 \nName: Villarin, Enzo Sala \nAge: 17 \nGrade level: 11 \nSection: Python \nDay of Birth: February 2, 2008");
                }
                else
                {
                    Console.WriteLine("Please Put Valid Student ID");
                }
            }
            else
            {
                Console.WriteLine("Please Write Something");
            }
        }
    }
} 