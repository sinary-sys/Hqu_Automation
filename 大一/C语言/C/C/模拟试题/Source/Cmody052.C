#include <stdio.h>
#include <conio.h>
void main()
{
  int r,m,n,temp;
  printf("Enter m,n: ");
  scanf("%d%d",&m,&n);
  if(m<n)
    {temp=m;m=n;n=temp;}
  r=m%n;
/*  while(r=0)*/
	while (r!=0)
    {m=n;
     n=r;
	/* r=m/n; */
	 r=m%n;
    }
  printf("H.C.F=%d \n",n);
  getch();
}
