
public class asc_des {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int [] x=new int[15];
		int i,tmp,a;
		for (i=0;i<15;i++)
		{
			x[i]=(int)(Math.random()*100);
			System.out.print("|"+x[i]);
		}
		System.out.print("\n");
		for(a=0;a<=14;a++)
		{
			for(i=0;i<=13;i++)
			{
				if(x[i]>x[i+1])
				{
					tmp=x[i];
					x[i]=x[i+1];
					x[i+1]=tmp;
				}
				
			}
			
		}
		System.out.println("after sorting:");
		for(i=0;i<15;i++)
		{
			System.out.print("|"+x[i]);
		}
		
		
		
		
	}

}
