#include <stdio.h>
#include <string.h>
void bubble_sort(char *str[],int);
void main(void) {
	int i,len;
	char *err[]={"cannot open file","read error","write error","media failure"};

	printf("Before sorting: \n");
	len=sizeof(err)/sizeof(char*);
	for (i=0;i<len;i++) printf("%s\n",err[i]);
	bubble_sort(err,len);
	printf("\nAfter sorting: \n");
	for (i=0;i<len;i++) printf("%s\n",err[i]);

}

void bubble_sort(char *str[],int n) {
	int pass,i;
	char *temp;
	for (pass=1;pass<n;pass++)
		for (i=0;i<n-pass;i++) {
			if (strcmp(str[i],str[i+1])>0)
			{
				temp=str[i];
				str[i]=str[i+1];
				str[i+1]=temp;
			}
		}
}