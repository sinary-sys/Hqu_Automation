#include <stdio.h>
#include <math.h>
double f(float x)
{
 /**/
	double result=0;
	if (x>1600 && x<=2100)
		result=(x-1600)*.05;
	else
	if (x>2100 && x<=3100)
		result=(x-1600)*.10-25;
	else
	if (x>3100)
		result=(x-1600)*.15-125;

	return result;


 /**/
}
void main()
{
  float x;
  double y;
  clrscr();
  printf("Please input a number:\n");
  scanf("%f",&x);
  y = f(x);
  printf("f(%.2f)=%.2f\n",x,y);
  getch();
}
