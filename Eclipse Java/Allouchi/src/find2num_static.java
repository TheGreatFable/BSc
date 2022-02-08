import java.util.Scanner;
public class find2num_static {
	
	static  int c=0;	

	public static void main(String[] args) {		
		
		int a;		
		int[]x=new int[15];
		String pos;
		fill(x);
		display(x);
		Scanner inp= new Scanner(System.in);
		System.out.print("\n");
		System.out.print("input a num: ");
		a=inp.nextInt();		
		pos= find(a,x);							
		if (c>0)	System.out.println("found "+c+" time at position: "+pos);
		else System.out.println("not found");
		inp.close();
	}

	static void fill(int[] y)
	{
		int i;
		for(i=0;i<y.length;i++)
			y[i]=(int)(Math.random()*100);
		return;
	}
	
	static void display(int[] y)
	{
		int i;
	for(i=1;i<y.length;i++)
		System.out.print("|"+y[i]);
	return;
	}


	static String find (int nb, int[] y) 
	{
		int it;
		String arr="";
		for (it=0;it<y.length;it++)
		{
			if(y[it]==nb)
			{
				c++;				
				arr=arr+it+" ";
			}
		}
		return arr;		 		
	}

	
}


