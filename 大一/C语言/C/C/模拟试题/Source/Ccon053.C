#include <stdio.h>
main()
{
  float a,b,c,max;
  /**/float fmax(float,float,float);                           /**/
  printf("Please input 3 integer:\n");
  scanf("%f%f%f",&a,&b,&c);
  max=fmax(a,b,c);
  printf("The max number is:%.2f\n", max);
  getch();
}

float fmax(float x,float y,float z)
{
  float m,n;
  n=(y>z)?y:z;
  m=/**/(x>n)?x:n;           /**/
  return(m);
}
