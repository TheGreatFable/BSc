import java.util.Scanner;

public class str_ascii {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String df;
		int d,u;		
		System.out.println("enter a String");
		Scanner inp=new Scanner(System.in);
		df=inp.next();
		for(u=0;u<df.length();u++)
		{
			char g=df.charAt(u);
			d=(int)g;
			if(d>=97)
				{
				d=d-32;
				g=(char)d;
				}
			
			System.out.print(g);

			
				
		}
		inp.close();
		
	}

}
