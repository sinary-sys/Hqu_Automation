#include <stdio.h>
#include <string.h>
void main()
{
  char s[20]="table left 100",t[20];
   /* char tab[4,2]={{'a','f'},{'b','e'},{'e','a'},{'f','b'}}; */
   char tab[4][2]={{'a','f'},{'b','e'},{'e','a'},{'f','b'}};
  int i,j=0;
  strcpy(t,s);
  while(t[j])
  {
    for(i=0;i<=3;i++)
    {
      if(t[j]==tab[i][0])
      {
	  /*  t[j]=tab[i][2];  */
		  t[j]=tab[i][1];
        break;
      }
    }
    j++;
  }
  printf("\nThe source string: %s\n",s);
  printf("\nThe target string: %s\n",t);
  getch();
}

