#include <stdio.h>
void main()
{
  int fibonacci[100],k,n;
  /* long int sum= 0 */long int sum=2 ;
  fibonacci[0]=fibonacci[1]=1;
  printf("Enter n:");
  scanf("%d",&n);
  for(k=2;/* k<=n */k<n;k++)
  {
    fibonacci[k]=fibonacci[k-1]+fibonacci[k-2] ;
    sum+= fibonacci[k] ;
  }
  for(k=0;k<=n-1;k++)
     printf("%d ",fibonacci[k]);
  printf("\nsum=%ld\n",sum);
  getch();
}









