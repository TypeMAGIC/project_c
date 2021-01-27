#pragma once

#include <stdlib.h>
#include <stdio.h>
#include <windows.h>
#include <string.h>
#include "struct.h"

#define COUNT_LIMIT 10

int count;
int* arr;
NUM* cointest;
NUM* ar;

/*int comp(int y, int z, int t_m)
{
	int result = 0, sw = 0;

	//(10000 + y * i) / (10 + y * i / y)
	for (int i = 0; i < 1000; i++)
	{
		int res = (t_m + y * i) / (t_m / (z * 2 - y) + i);//(((y + z) / 2) + y) / 2 < res && res < (((y + z) / 2) + z) / 2
		if (y < res && res < z)
		{
			printf("%d %d\n", res, i);
			if (res == (y + z) / 2)
			{
				printf("ã��");
				sw = 1;
				result = i;
				break;
			}
		}
	}
	if (sw == 0)
	{
		printf("�� ã��");
	}
	return result;
}*/

void print_per(int percent)
{
	printf("%d%%----------------------\n\n", percent);//�ۼ�Ʈ�� ����Ʈ
}

void print_num(NUM* arr)
{
	for (int i = 0; i < COUNT_LIMIT; i++)
	{
		printf("%d : %d\n", arr[i].p_price, arr[i].num);//��� �ܰ� : ��ȣ ����Ʈ
	}
	printf("\n\n");
}

int between_a_b(int a, int b)
{
	int result = (a + b) / 2;//a�� b�� �߰��� ���
	count++;
	if (count > COUNT_LIMIT)
	{
		return result;
	}
	else
	{
		//printf("%d : %d\n", result, count);
		arr[count] = result;//�� �ϱ� ���� ����� ������ �迭(���� ū ��� ������ �Һ�)�� ����
		return(between_a_b(a, result));//����Լ�
	}
}

int test(int x, int y, int z, int n)
{
	int current = n * (1 - (z * 0.01));//���簡(�϶� ��) ���
	between_a_b(current, n);//���簡(������ ����)�� �� ����� �߰��� ���
	count = 0;//���� ����� ���� �ʱ�ȭ
	print_per(z);//�ۼ�Ʈ�� ����Ʈ
	return current;
}

void comp_price(int x, int current)
{
	int num1 = x, num2 = current, comp_num = 0;
	cointest = malloc(sizeof(NUM) * 100);
	ar = malloc(sizeof(NUM) * COUNT_LIMIT);

	for (int i = 1; i <= 100; i++)
	{
		//printf("�� ���� %d��, �� %d��, ��� �ܰ� : %d, %d��°\n", i + 1, num2 * i + num1, (num2 * i + num1) / (i + 1), i);

		cointest[i - 1].p_price = (num2 * i + num1) / (i + 1);//�� ��� ��� �ܰ� ���
		cointest[i - 1].num = i;//��ȣ �ο�

		for (int j = 0; j < 10; j++)
		{
			if (cointest[i - 1].p_price == arr[j] && cointest[i - 1].p_price != comp_num)
			{
				comp_num = cointest[i - 1].p_price;//����
				for (int l = 0; l < COUNT_LIMIT; l++)
				{
					if (ar[l].num == 0)
					{
						ar[l] = cointest[i - 1];//����Ʈ�� �迭�� �� �ֱ�
						break;
					}
				}
			}
		}
	}
	print_num(ar);//��� �ܰ� : ��ȣ �� ����Ʈ
}