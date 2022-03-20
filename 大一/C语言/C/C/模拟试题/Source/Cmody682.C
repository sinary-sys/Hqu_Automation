#include <stdio.h>
#include <conio.h>
#include <math.h>

int main()
{  float x,y;
   void msg_fun(float,float);
   printf("Please input the dot(x,y):");
   scanf("%f,%f",&x,&y);
   msg_fun(/* 5 */x,y);
   getch();
   return 0;
}

void msg_fun(float x, /* y */float y)
{ double r;
  r=sqrt(x*x+y*y);
  if (/* r>=3.0 */r<3.0) printf("InSide\n");
  else printf("OutSide\n");
}