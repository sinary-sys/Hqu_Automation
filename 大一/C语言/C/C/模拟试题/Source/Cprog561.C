#include <stdio.h>
#include <math.h>
#include <conio.h>
double fun(float x)
{ /**/

	if (x>0) return 1+exp(x);
	else if (x<0) return log(x*x+3.5);
	else return 1;



  /**/
}

void main()
{ printf("fun(-1.5)=%lf\n",fun(-1.5));
  printf("fun(0)=%lf\n",fun(0));
  printf("fun(3.7)=%lf\n",fun(3.7));
  getch();
}