#include <stdio.h>
#include <math.h>
double f(float a,float b,float c)
{
 /**/

	if (a>0)
		return (-b+sqrt(b*b-4*a*c))/(2*a);
	else
		return (-b-sqrt(b*b-4*a*c))/(2*a);


 /**/
}

void main()
{
  float x;
  printf("The bigger root is %.2f\n",f(1,5,6));
  getch();
}
