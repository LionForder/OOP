using System;

namespace OneOOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string eyeD = Console.ReadLine();
            string hairD = Console.ReadLine();
            string nationalityD = Console.ReadLine();
            int bloodD = Convert.ToInt32(Console.ReadLine());

            Family dad = new Family()
            {
                WhoFam = "dad",
                ColorOfEye = eyeD,
                ColorOfHair = hairD,
                Nationalities = nationalityD,
                GroupOfBlood = bloodD
            };

            string eyeM = Console.ReadLine();
            string hairM = Console.ReadLine();
            string nationalityM = Console.ReadLine();
            int bloodM = Convert.ToInt32(Console.ReadLine());

            Family mom = new Family("mom",hairM, eyeM, nationalityM, bloodM);

            Family child = mom + dad;
            Console.WriteLine(mom.ToString());
            Console.WriteLine(dad.ToString());
            Console.WriteLine(child.ToString());
        }
    }
}

/* поставить switch с вариантами выбора ответа(1, 2, 3..., n)
 * либо накидать методов с перегрузкой в классе
 * ласт вариант - ввести свое
 * 
 * Сравнивать национальность матери и отца
 * Если они равны, то национальность ребенка = национальности
 * родителей, иначе {dad.nationalities}-{mom.nationalities}
 * 
 * Когда-нибудь расписать через Random случайность цвета глаз
 * 
 * Переписать по группе крови через условия
 * 
 * Прописать для WhoFam нормальный вызов
 */
