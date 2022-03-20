#include <stdio.h>
void main()
{
  int f,s,t,n;
  printf("\nThe list is:\n");
  for(n=100;n<1000;n++)
  {
    f=n%10;
    s=(n%100)/10;
   /* t=n%100; */
	t=n/100;
   /* if(t*t*t+s*s*s+f*f*f=n) */
	if (t*t*t+s*s*s+f*f*f==n)
    printf("%d  ",n);
  }
  printf("\n");
  getch();
}
