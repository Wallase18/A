struct values /* estrutura de dados para enviar os parâmetros  */
{
	float num1;
	float num2;
	char operation;
};

program COMPUTE /* nome do programa */
{
	version COMPUTE_VERS /* nome da versão do programa */
	{
		float ADD(values) = 1;
		float SUB(values) = 2;
		float MUL(values) = 3;
		float DIV(values) = 4;
	} = 6;
} = 456123789;

