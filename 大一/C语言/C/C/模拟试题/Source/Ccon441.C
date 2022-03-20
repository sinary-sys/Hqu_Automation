#include <stdio.h>
#include <math.h>
void main()
{
  double a,b,c,circle,area;
  printf("Input 2 edges:");
  scanf(/**/"%lf,%lf"        /**/,&a,&b);
  c=sqrt(/**/a*a+b*b           /**/);
  circle=a+b+c;
  area=/**/0.5*a*b          /**/ ;
  printf("circle=%lf\n",circle);
  printf("area=%lf\n",area);
  getch();
}


