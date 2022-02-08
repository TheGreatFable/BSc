
public class max_min_avg {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double [] a=new double[25];
		int i;
		double avg=0, max, min;
		for (i=0;i<25;i++)
		{
			a[i]=(Math.random()*250)+1;
			System.out.print("|"+a[i]);
		}
		max=min=a[0];
		for(i=1;i<25;i++)
		{
			if(a[i]>max) max=a[i];
			if(a[i]<min) min=a[i];
			avg=avg+a[i];
		}
		avg=avg/25;
		System.out.print("\n");
		System.out.println("Max is:"+ max);
		System.out.println("Min is:"+ min);
		System.out.println("Avg is:"+ avg);
		
		
	}

}
