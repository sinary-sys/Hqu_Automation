#include <stdio.h>
#include<math.h>
#include <conio.h>
void main()
{ int x,na,nb,nc;
  na=nb=nc=/**/ 0  /**/;
  printf("Input integer number, end with 0:\n");
  scanf("%d",&x);
  while(x)
  { if(x<-10)
      /**/ na++     /**/;
    else if(x>0)
      ++nb;
    if( abs(x%10)==/**/ 7    /**/)
       ++nc;
    scanf("%d",&x);
  }
  printf("na=%d   nb=%d   nc=%d\n",na,nb,nc);
  getch();
}

