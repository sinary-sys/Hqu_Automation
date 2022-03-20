#include <stdio.h>
#include <math.h>
/**/ integer /**/Is_Prime( int x )  
{  
  int /**/ i/**/;
  if(x<=0)
    return(-1);
  else
    {
     k=(int)sqrt((double)x);
     for(i=2;i<=k;i++)
        if(x%i== /**/ 1 /**/)
           {return(0);
           }
     return (1);
    }  
}

void main()
{
  int a;
  printf("Input a number: ");
  scanf("%d",&a);
  printf("%d\n", Is_Prime(a));
  getch();
}
