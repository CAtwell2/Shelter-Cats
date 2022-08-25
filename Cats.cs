Console.Write("Enter the number of female cats: ");
int FemaleCats = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of male cats: ");
int MaleCats = Convert.ToInt32(Console.ReadLine());
int TotalCats = FemaleCats + MaleCats;
float FemalePercentage = (FemaleCats /(float) TotalCats) * 100;
float MalePercentage = (MaleCats /(float) TotalCats) * 100;
Console.WriteLine("Female Cats Percentage:"+FemalePercentage);
Console.WriteLine("Male cats percentage:"+MalePercentage);
        
    