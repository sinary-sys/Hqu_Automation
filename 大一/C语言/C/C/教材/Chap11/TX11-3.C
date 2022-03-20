#include <stdio.h>
void main(void) {
	struct employee {
		int EId;
		char name[20];
		char tel[12];
		float salary;
	}newEmp,emp1={2015,"John","0595576723",5000.0},emp2;
	printf("Input a new employee: \n");
	printf("Eid: ");
	scanf("%d",&newEmp.EId);
	printf("name: ");
	scanf("%s",newEmp.name);
	printf("tel: ");
	scanf("%s",newEmp.tel);
	newEmp.salary=emp1.salary;
	emp2=newEmp;

	printf("emp2's details: \n");
	printf("Eid\tname\ttel\t\tsalary\n");
	printf("%d\t%s\t%s\t%.2f\n",emp2.EId,emp2.name,
					emp2.tel,emp2.salary);
}