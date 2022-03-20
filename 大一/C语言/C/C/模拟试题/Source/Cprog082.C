#include <string.h>
#include <stdio.h>
void f(char p[][20],int n);
void main()
{
 int i;
 char p[][20]={"abc","xabdfg","abbd","dcdbe","cd"};
 f(p,5);
 clrscr();
 for(i=0;i<5;i++)
    printf("%s\n",p[i]);
 getch();
}
void f(char p[][20],int n)
{
 /**/

	int i,j;
	char temp[20];
	for (i=0;i<n-1;i++)
		for (j=i+1;j<n;j++)
			if (strcmp(p[i],p[j])>0)
			{
				strcpy(temp,p[i]);
				strcpy(p[i],p[j]);
				strcpy(p[j],temp);
			}








 /**/
}
