#include <stdio.h>
struct fee {
	int i;
	char c;
}foo[5]={{1,'a'},{2,'b'},{3,'c'},{4,'d'}},*fp;

void main(void) {
	int k;
	printf("Number\tCharacter\n");
	for (k=0;k<4;k++)
		printf("%d\t%c\n",(foo+k)->i,(foo+k)->c);

	printf("After being operated: \n");
	fp=foo;

	printf("%c\t",(++fp)->c);
	printf("%d\t",++fp->i);
	printf("%d\t",(fp++)->i);
	printf("%c\t",++fp->c);
	printf("%d\t",fp->i++);
	printf("%d\n",fp->i);

	printf("Number\tCharacter\n");
	for (k=0;k<4;k++)
		printf("%d\t%c\n",foo[k].i,foo[k].c);
}