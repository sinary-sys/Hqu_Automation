#include <stdio.h>
#include <conio.h>
/**/#define        /**/ N 13
void main()
{ int a[N]={1,6,-19,0,3,7,-8,5,22,11,-5,16,-10};
  int i, /**/ x    /**/;
  printf("Input a number to be searched:");
  scanf("%d",&x);
  for(/**/i=0     /**/; i<N; i++)
    if(a[i]==x)
      break;
  if(i<N)
    printf("It's found.\n");
  else
    printf("Not exist.\n");
  getch();
}
