#include <stdio.h>
#include <math.h>
#include <conio.h>
double fun(double x)
{ /**/

	return (3*sin(x)+pow(x,3))/(1.7+fabs(x-2.2));

 /**/
}

void main()
{ double x;
  printf("Please input x:");
  scanf("%lf",&x);
  printf("\nfun(%.3lf) = %.3lf\n",x,fun(x));
  getch();
}
