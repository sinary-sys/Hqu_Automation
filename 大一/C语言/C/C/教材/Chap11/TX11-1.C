#include <stdio.h>
void main(void) {
	struct employee {
		int EId;
		char name[20];
		char tel[12];
		float salary;
	}emp1={2015,"John","0595576723",5000.0};
	printf("Eid\tname\ttel\t\tsalary\n");
	printf("%d\t%s\t%s\t%.2f\n",emp1.EId,emp1.name,emp1.tel,emp1.salary);
}