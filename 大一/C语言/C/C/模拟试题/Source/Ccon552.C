#include <stdio.h>
#include <conio.h>
#define N 15
void main()
{ int x[N]={-7,2,6,-19,0,13,7,15,-8,35,10,-5,1,19,28};
  int /**/ i  /**/, j, max_at, t ;
  for(i=0; i<N-1; i++)
  { max_at=i;
    for(j=i+1; j</**/ N  /**/; j++)
      if(x[max_at]<x[j]) max_at=j;
      if(max_at!=i)
      { t=x[i];
        x[i]=x[max_at];
        /**/x[max_at]=t;            /**/
      }
  }
  printf("Sorted numbers:\n");
  for(i=0;i<N;i++)
     printf("%4d ",x[i]);
  printf("\n");
  getch();
}
