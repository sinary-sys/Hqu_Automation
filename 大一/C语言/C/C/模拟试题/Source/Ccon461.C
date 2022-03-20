#include <stdio.h>
void main()
{
 float x;
 int n;
 double Calculating(int);
 printf("Please input n (n>=1 and n<=1000):");
 scanf("%d",&n);
 printf("Calculating(%d)=%lf\n",n,/**/ Calculating(n)           /**/);
 getch();
}

double Calculating(int n)
{ int i, sign=1;
  double r=0.0;
  if(n>=1&&n<=1000)
    for( i=1;i<=n;i++)
    { r+=sign*(1.0/i);
	/**/ sign=-sign;           /**/
    }
  return /**/ r    /**/;
}
