#include "include.h"

void main()
{
	arr = (int*)malloc(sizeof(int) * COUNT_LIMIT);
	int x = 0, y = 0, z = 0, n = 0, result = 0;

	//printf("\n\n���ڱ�, ����, �϶���, ���� ���Ű� : ");
	scanf_s("%d %d %d", &x, &y, &n);//���ڱ�, ����, ���� ���Ű�(test : 1000 1 1000)

	for (int i = 100; i >= 1; i--)
	{
		comp_price(x, test(x, y, i, n));//���簡(current)�� �����ϸ鼭 ���� ���
	}
}