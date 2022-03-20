#include <stdio.h>
#include <math.h>
void sort(int a[], int m)
{ int i, j, t,swap;
  for( i=0; i< /**/m-1     /**/ ; i++ )
  {
     swap = 0;
     for( j=0; j < m-i-1; j++)
     {
	   if /**/ (a[j]<a[j+1])                /**/
       {
         swap = 1;
         t = a[j];
		 a[j] = /**/a[j+1]        /**/;
         a[j+1] = t;
       }
     }
     if(!swap) break;
  }
}
void main()
{
  int a[] = {23,55,8,32,18,2,9};
  int i,k = sizeof(a)/sizeof(int);
  sort(a,k);
  for(i=0;i<k;i++)
    printf("%d  ",a[i]);
  printf("\n");
  getch();
}