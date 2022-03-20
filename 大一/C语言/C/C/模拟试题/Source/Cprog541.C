#include <stdio.h>
#include <math.h>
#include <conio.h>
double fun(double x)
{ /**/
	
	return (pow(x,3)-1)/(fabs(exp(3*x)-sin(x))+1.8);

  /**/
}

void main()
{ double x;
  printf("Pleae input x:");
  scanf("%lf",&x);
  printf("\nfun(%6.3lf) = %6.3lf\n",x,fun(x));
  getch();
}
