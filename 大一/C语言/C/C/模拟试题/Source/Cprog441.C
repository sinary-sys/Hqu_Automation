#include <stdio.h>
#include <math.h>
double fun(double x)
{/**/
	return (2*sin(x)+exp(x))/(cos(x)+1.2);



 /**/  
}

void main()
{ 
 printf("fun(1.65) = %7.3lf\n", fun(1.65));  
 getch();
}