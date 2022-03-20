#include <stdio.h>
#include<conio.h>
int main()
{ int a[10],pass,j,temp;
  printf("Enter 10 integers:");
  for(j=0;j<10;j++) scanf("%d",&a[j]);
  for(pass=1; pass<10; /* pass+=2 */pass++)
    for(j=0;j<10-pass;j++)
	if(a[j]>a[j+1])
	{
	  temp=a[j];
	  a[j]=a[j+1];
	  /* a[j+1]=a[j]; */a[j+1]=temp;
	}
  printf("Sorted numbers :\n");
  for(j=0;/* j<=10 */j<10; j++) printf("%d ",a[j]);
  printf("\n");
  getch();
  return 0;
}

