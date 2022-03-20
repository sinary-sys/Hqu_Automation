#include <stdio.h>
void main(void) {
	int a[50]={83,77,92,65,82,58},i,len=6,data,pos;
	for (i=0;i<len;i++) printf("%4d",a[i]);
	printf("\n");
	printf("Input the data to insert and the inserted position: ");
	scanf("%d%d",&data,&pos);
	for (i=len-1;i>=pos-1;i--) a[i+1]=a[i];
	a[pos-1]=data;
	len++;
	printf("After the insertion: \n");
	for (i=0;i<len;i++) printf("%4d",a[i]);
	printf("\n");
	printf("Input the deletion position: ");
	scanf("%d",&pos);
	for (i=pos;i<len;i++) a[i-1]=a[i];
	len--;
	printf("After the deletion: \n");
	for (i=0;i<len;i++) printf("%4d",a[i]);
	printf("\n");
	printf("Input the data to search: ");
	scanf("%d",&data);
	for (i=0;i<len;i++)
		if (a[i]==data) {
			printf("Found %d at position %d\n",data,i+1);
			break;
		}
	if (i==len) printf("Not found %d\n",data);
}