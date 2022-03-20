#include <stdio.h>
void main(void)
{
	char *name[5]={"japan","china","australia","italy","germany"},*temp;
	int i,j;
	for (i=0;i<5;i++) puts(name[i]);
	for (i=0;i<4;i++)
		for (j=i+1;j<5;j++)
			if (strcmp(name[i],name[j])>0)
			{
				temp=name[i];
				name[i]=name[j];
				name[j]=temp;
			}
	for (i=0;i<5;i++) puts(name[i]);
}