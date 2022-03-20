#include <stdio.h>
void main(void)
{
	char name[10][20],temp[20];
	int i,j,pos;

	printf("Input the names of ten students: \n");
	for (i=0;i<10;i++) gets(name[i]);

	for (i=0;i<9;i++)
	{
		pos=i;
		for (j=i+1;j<10;j++)
			if (strcmp(name[j],name[pos])<0) pos=j;
		if (pos!=i) {
			strcpy(temp,name[i]);
			strcpy(name[i],name[pos]);
			strcpy(name[pos],temp);
		}
	}
	printf("After sorting: \n");
	for (i=0;i<10;i++)	puts(name[i]);
}