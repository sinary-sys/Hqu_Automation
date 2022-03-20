#include <stdio.h>
void DecToHex(unsigned int data,int hex[30],int *resultlen)
{/**/
	int i=0;
	while (data>0)
	{
		hex[i++]=data % 16;
		data/=16;
	}
	*resultlen=i;




 /**/
}
void main()
{
  unsigned int data,hex[30];
  int i,len=0;
  scanf("%u",&data);
  DecToHex(data,hex,&len);
  printf("Hex number is: ");
  for(i=len-1;i>=0;i--)
    if(hex[i]>9)
      putchar(hex[i]-10+'A');
    else
      putchar(hex[i]+'0');
  printf("\n");
  getch();
}
