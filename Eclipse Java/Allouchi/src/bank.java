
public class bank {

	private String name;
	private String address;
	private double interest;
	
	double getInterest()
	{
		return interest;
	}
	
	public bank()
	{
		interest = 5.2;
	}
	
	void setInterest(double rate)
	{
		interest =rate;
	}
	
	public bank(double x)
	{
		interest=x;
	}
}
