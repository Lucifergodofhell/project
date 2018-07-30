using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppclc
{
    class Calculator
    {
	    public int sub(int a ,int b)
	    {
		    int c=a-b;
		    return c;
	    }
		
	 public int Add(int a,int b)
	 {
	 	return a+b;
	 }
	 
	 public int div(int a,int b)
	 {
	     try{
	 	return a/b;
		}
		catch{
			Console.WriteLine("Div by zero error");
		}
	 }
	 public int mul(int a,int b){{
	 	return a*b;
	 }
		 
	}
}
