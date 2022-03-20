#include <stdio.h>
#define N 12
int count(int s[])
{
  int i,c=0;
  float sum=0,aver;
  for(i=0;i<N;i++)
    sum+=s[i];
  aver=/**/sum/N;        /**/
  for(i=0;i<N;i++)
   {if(s[i]>=aver)
      c++;
   }
  return(/**/c   /**/);
}

void main()
{
  int score[N]={67,78,66,79,73,82,69,85,77,80,93,72};
  int cn;
  cn=/**/  count     /**/ (score);
  printf("Count is %d\n",cn);
  getch();
}


