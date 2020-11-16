public class Delenie_na_3 
{
	public static void main(String[] args) 
	{
		int x = 123456, s = 0;
		while (x > 0) 
		{
			s += x % 10;
			x /= 10;
		}
		
		if (s>10)
		{
			x=s;
			s=0;
			while (x>0)
			{
			    s += x % 10;
			    x /= 10;
			}
		}
		
		if (s==3 || s==6 || s==9)
		   {
               System.out.println("Число " + s + " делится на 3");
		   }
		else
		   {
               System.out.println("Число " + s + " не делится на 3");
		   }
	}
}