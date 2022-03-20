#include <stdio.h>
#include <conio.h>
void main()
{
  int x,y,t;
  scanf("%d,%d",&x,&y);
  if (x>y)
   {
	/* y=x; t=x; y=t;*/
	 t=x;x=y;y=t;
   }
  while(++x<y)
   {
    if(x%2!=0)
   /* break; */
	continue;
    printf("%d\n",x);
   }
  getch();
}


