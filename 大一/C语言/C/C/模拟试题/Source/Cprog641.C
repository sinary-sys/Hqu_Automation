#include <stdio.h>
#include <conio.h>
#include <math.h>

double fun(float x)
{ /**/

	return (0.18*(x*x+1.3))/(fabs(sin(x))+2.56);
 /**/
}

int main()
{
  printf("\nfun(%.3f) = %.3lf\n",0.125,fun(0.125));
  getch();
  return 0;
}