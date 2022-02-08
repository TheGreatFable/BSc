import java.util.Scanner;

public class inputnumbersfor {

	public static void main(String[] args) {
		// TODO Auto-generated method stub


		int nb, a, i;
		a=(int)(Math.random()*100);
		System.out.println("input numbers until you gess it: ");
		Scanner imp=new Scanner(System.in);
		nb=imp.nextInt();
		for (i=1; i<5;i++)
		{
		if (nb!=a)
		{
			if (nb>a) System.out.println("its less");
			if (nb<a) System.out.println("its higher");
			System.out.print("re-enter a number: ");
			nb=imp.nextInt();
		}
		else {
			System.out.print("Sibta");
			i=7;
		}
		}
		if (i==5) System.out.print("you lost");
		
	
		
	}

}
