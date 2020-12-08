import java.util.Scanner;
public class Vector 
{
    public static void main(String[] args) 
    {
       Scanner neo = new Scanner(System.in);
       System.out.println("Enter vector x");
       int x = neo.nextInt();
       System.out.println("Enter vector x1");
       int x1 = neo.nextInt();
       System.out.println("Enter vector y");
       int y = neo.nextInt();
       System.out.println("Enter vector y1");
       int y1 = neo.nextInt();
       System.out.println("Enter vector z");
       int z = neo.nextInt();
       System.out.println("Enter vector z1");
       int z1 = neo.nextInt();
       
       System.out.println(x + ", " + y + ", " + z);
       System.out.println("S = " + Math.sqrt(Math.pow(x, 2) + Math.pow(y, 2) + Math.pow(z, 2)));
       System.out.println("Вычетание векторов = (" + (x1-x) + ";" + (y1-y) + ";" + (z1-z) + ")");
       System.out.println("Сложение векторов = (" + (x+x1) + ";" + (y+y1) + ";" + (z+z1) + ")");
       System.out.println("Скалярное произведение = (" + (x1*x) + ";" + (y1*y) + ";" + (z1*z) + ")");
    }
}