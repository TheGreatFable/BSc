import java.util.Scanner;

public class static_findnum {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int a,pos;
		int[]x=new int[15];
		fill(x);
		display(x);
		Scanner inp= new Scanner(System.in);
		System.out.print("\n");
		System.out.print("input a num: ");
		a=inp.nextInt();
		pos= find(a,x);
		inp.close();
		if (pos>=0)	System.out.println(pos);
		else System.out.println("not found");
	}

	static void fill(int[] y)
	{
		int i;
		for(i=0;i<y.length;i++)
			y[i]=(int)(Math.random()*1000);
		return;
	}
	
	static void display(int[] y)
	{
		int i;
	for(i=1;i<y.length;i++)
		System.out.print("|"+y[i]);
	return;
	}


	static int find (int nb, int[] y)
{
		int i;
		for (i=0;i<y.length;i++)
		{
			if(y[i]==nb)
			{
				
				return i;			
			}
		}
		 return -1;
					
}

}

