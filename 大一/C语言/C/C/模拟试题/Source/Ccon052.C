#include <stdio.h>
#include <math.h>
void sort(int a[], int m)
{ int i, j, k, t;
  for( i = 0; i < m-1; i++ )
  {  k = i;
	 for( j=i+1; j< /**/m   /**/; j++)
	   if( a[j] < a[k] ) /**/k=j   /**/;
     if( k != i )
     { t = a[k];
       a[k]= a[i];
	   a[i] = /**/t  /**/;
     }
  }
}

void main()
{
  int a[] = {72,25,58,32,2,15,7,64};
  int i,m = sizeof(a)/sizeof(int);
  sort(a,m);
  for(i=0;i<m;i++)
    printf("%d  ",a[i]);
  printf("\n");
  getch();
}