#include <stdio.h>
main()
{
  int i,a[10]={9,26,35,8,6,19,69,3,5,95};
  int min1,min2;
  i=0;
  min1=a[0]<a[1]?a[0]:a[1];
  min2=a[0]>a[1]?/**/a[0]:a[1];             /**/
  for(i=2;i<10;i++)
  {
    if(a[i]<min1)
    {
     min2=min1;
     min1=a[i];
    }
    else if(a[i]<min2)
	/**/min2=a[i];            /**/
  }

  printf("min1=%d,min2=%d\n", min1,min2);
  getch();
}
