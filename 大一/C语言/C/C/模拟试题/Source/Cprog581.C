#include <stdio.h>
#include <math.h>
#include <conio.h>
double fun(double x)
{ /**/

	return (sin(2*x)+3*cos(x))/sqrt(1.3+cos(2*x));

 /**/
}

void main()
{ double x;
  printf("Pleae input x:");
  scanf("%lf",&x);
  printf("\nfun(%.3lf) = %.3lf\n",x,fun(x));
  getch();
}
