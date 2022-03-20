#include <stdio.h>
#include <conio.h>
void main()
{ int i,s[10];
  float sum=0;
  int count=0;
  printf("Please input 10 numbers:\n");
  scanf("%d", /**/      /**/);
  for(i=1; i<10; i++)
  { scanf("%d",&s[i]);
    if(s[i]>s[0]) 
    { sum+=s[i];
      /**/         /**/
    }
  }
  if(count==0)
      printf("Not found!");
  else
      printf("%.2f",sum/count);
  getch();
}
