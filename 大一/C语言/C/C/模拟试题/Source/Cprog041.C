#include <stdio.h>
#include <math.h>
double f(float x)
{
 /**/

	double y=0;
	if (x>0)
		y=(fabs(x)+3.2)/(sin(x)+2);
	return y;

 /**/
}

void main()
{
  float x;
  double y;
  printf("Please input a number: \n");
  scanf("%f",&x);
  y = f(x);
  printf("f(%.3f)=%.3f\n",x,y);
  getch();
}