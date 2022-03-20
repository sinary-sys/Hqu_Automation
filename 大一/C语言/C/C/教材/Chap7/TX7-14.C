#include <stdio.h>
#include <string.h>
void main()
{
	char name[5][10],temp[10];
	int pass,i;
	for (i=0;i<5;i++) scanf("%s",name[i]);
	for (pass=1;pass<5;pass++)
		for (i=0;i<5-pass;i++)
			if (strcmp(name[i],name[i+1])>0)
			{
				strcpy(temp,name[i]);
				strcpy(name[i],name[i+1]);
				strcpy(name[i+1],temp);
			}
	printf("After sorting: \n");
	for (i=0;i<5;i++) printf("name[%d]: %s\n",i,name[i]);
}
