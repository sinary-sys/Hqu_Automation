#include <stdio.h>
#include <math.h>
void main()
{
  float a[3],s,area;
  int i;
  printf("Please input 3 numbers:\n");
  for(i=0; i<3; i++)
/*	scanf("%f", a[i] );*/
	scanf("%f",&a[i]);
/* if( a[0]+a[1]>a[2] || a[1]+a[2]>a[0] || a[0]+a[2]>a[1] ) */
  if (a[0]+a[1]>a[2] && a[1]+a[2]>a[0] && a[0]+a[2]>a[1])
  {
    s = (a[0]+a[1]+a[2])/2;
    area = sqrt(s*(s-a[0])*(s-a[1])*(s-a[2]));
    printf("area is %.2f\n",area);
  }
  else
    printf("error.\n");
  getch();
}
