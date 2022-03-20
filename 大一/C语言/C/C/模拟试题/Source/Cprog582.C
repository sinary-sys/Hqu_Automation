#include <stdio.h>
#define RW 3
#define CL 5
int fun(int a[][CL])
{ /**/

	int i,j,max=a[0][0];
	for (i=0;i<RW;i++)
		for (j=0;j<CL;j++)
			if (a[i][j]>max) max=a[i][j];
		
	return max;


  /**/
}

void main()
{ int arra[RW][CL] = {{18,21,31,78,5},{11,16,43,14,25},{28,42,21,14,15}};
  int i,j,k;
  printf("Original array is:\n");
  for(i=0; i<RW; i++)
    for(j=0;j<CL;j++)
       printf("%6d", arra[i][j]);
    printf("\n");      
  printf("\nThe max number is:%6d", fun(arra));  
  getch();
}

