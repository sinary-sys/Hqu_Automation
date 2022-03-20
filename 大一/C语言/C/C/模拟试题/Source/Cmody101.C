#include <stdio.h>
#define F(x) (x*x-2.3*x+5.6)/(x+8.2)
void main()
{
  float a=6.0,b=3.0,c;
  /* int s;  */
  float s;
  printf("\nPlease input c: ");
/*  scanf("%f", c); */
	scanf("%f",&c);
  /* s=F(a,b,c);  */
  s=F(a)+F(b)-F(c);
  printf("\ns=%.2f\n",s);
  getch();
}
