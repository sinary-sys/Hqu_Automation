#include <stdio.h>
void func(int *);
void main(void)
{
	int data[8],i;
	printf("Enter 8 number: ");
	for (i=0;i<8;i++) scanf("%d",&data[i]);
	func(data);
	printf("\nAfter sorting: \n");
	for (i=0;i<8;i++) printf("%4d",data[i]);
}
void func(int *s) {
	int i,j,work;
	for (i=0;i<7;i++)
		for (j=i+1;j<8;j++)
			if (*(s+i)<*(s+j)) {
				work=*(s+i);
				*(s+i)=*(s+j);
				*(s+j)=work;
			}
}