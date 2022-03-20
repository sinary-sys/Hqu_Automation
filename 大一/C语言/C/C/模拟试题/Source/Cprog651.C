#include <stdio.h>
#include <conio.h>
#include <math.h>

double fun(float x)
{ /**/

	return (1.1*x+exp(x)-0.75)/(fabs(x-0.22)+1.03);

 /**/
}

int main()
{
	printf("\nfun(%.3f) = %.3lf\n",0.062,fun(0.062));
	getch();
	return 0;
} 