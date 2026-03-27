using System;

public class Manager
{
	private readonly DateTime Startup;
	public Manager()
	{
		Startup = DateTime.Now;
	}
	public DateTime GetStartup()
	{
		return Startup;
	}
}
