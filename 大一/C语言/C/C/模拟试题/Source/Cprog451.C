#include <stdio.h>
#include <math.h>
double fun(double x,int n)
{/**/
	return 3*pow(x,n)/((2*x-1)*(x+3)+0.8);



 /**/
}

void main()
{
  printf("fun(2.3,5) = %7.3lf\n", fun(2.3,5));
  getch();
}
