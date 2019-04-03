using System;

//CHARLES WILLIAN VIEIRA DA SILVA

namespace Pilha_e_Fila
{
    class Elemento
    {
        public int numero;
        public Elemento proximo;
    }

    class Pilha
    {
        public Elemento topo = null;
        public int tamanho = 0;
        public void exibir()
        {
            Elemento aux = topo;

            while (aux != null)
            {
                Console.WriteLine($"{aux.numero}");
                aux = aux.proximo;
            }
        }
        public void exibir(Elemento aux)
        {
            if (aux != null)
            {
                Console.WriteLine($"{aux.numero}");
                exibir(aux.proximo);
            }
        }
        public void empilhar (int x)
        {
            Elemento meuElemento = new Elemento();
            if (!consultar(x))
            {
                meuElemento.numero = x;
                meuElemento.proximo = topo;
                topo = meuElemento;
            }
            else
            {
                Console.WriteLine("Elemento já está na pilha!");
            }
        }
        public bool consultar (int x)
        {
            Elemento aux = topo;

            while (aux != null && aux.numero != x)
            {
                aux = aux.proximo;
            }
            if (aux != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool consultar (Elemento aux, int x)
        {
            if (aux == null)
            {
                return false;
            }
            else if (aux.numero == x)
            {
                return true;
            }
            else
            {
                return (consultar(aux.proximo, x));
            }
        }
        public Elemento desempilhar()
        {
            Elemento aux = topo;

            if (topo == null)
            {
                return null;
            }
            else
            {
                topo = topo.proximo;
                return (aux);
            }
        }
    }


    class Fila
    {
        public Elemento inicio = null;
        public Elemento fim = null;
        public int tamanho = 0;


        public void enfileirar(int x)
        {
            if (pesquisar(x))
            {
                Console.WriteLine("Elemento já existe");
            }
            else
            {
                Elemento novo = new Elemento();
                novo.numero = x;
                novo.proximo = null;
                tamanho++;

                if (inicio == null)
                {
                    inicio = novo;
                }
                else
                {
                    fim.proximo = novo;
                }
                fim = novo;
            }
        }
        public Elemento desenfileirar()
        {
            Elemento aux = inicio;

            if (inicio != null)
            {
                inicio = inicio.proximo;
                tamanho--;

                if (inicio == null)
                {
                    fim = null;
                }
            }
            return aux;
        }
        public bool pesquisar(int x)
        {
            Elemento aux = inicio;

            while (aux != null && aux.numero != x)
            {
                aux = aux.proximo;
            }
            if (aux != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool pesquisar(int x, Elemento inicio)
        {
            if (inicio == null)
            {
                return false;
            }
            else if(x == inicio.numero)
            {
                return true;
            }
            else
            {
                return (pesquisar(x, inicio.proximo));
            }
        }
        
        public void exibir()
        {
            Elemento aux = inicio;
            while (aux != null)
            {
                Console.WriteLine(aux.numero);
                aux = aux.proximo;
            }
        }

        public void exibir(Elemento el)
        {
            if (el != null)
            {
                Console.WriteLine("Fim da lista");
            }
            else
            {
                Console.WriteLine(el.numero);
                exibir(el.proximo);
            }
        }

        public void esvaziar()
        {
            this.inicio = null;
            this.fim = null;
            tamanho = 0;
        }

        public bool testeVazia()
        {
            return (inicio == null);
        }

        public int maiorInicio(Elemento inicio,Elemento el, int cont)
        {
            if (el == null)
            {
                return cont;
            }
            else
            {
                if (el.numero > inicio.numero)
                {
                    return (maiorInicio(inicio, el.proximo, cont+1));
                }
                else
                {
                    return (maiorInicio(inicio, el.proximo, cont));
                }
            }
        }

        public int maiorInicio()
        {
            Elemento aux = inicio.proximo;
            int cont = 0;
            while (aux != null)
            {
                if (aux.numero > inicio.numero)
                {
                    cont++;
                }
                aux = aux.proximo;
            }
            return cont;
        }
        public int maiorFim(Elemento fim, Elemento el, int cont)
        {
            if (el == null)
            {
                return cont;
            }
            else
            {
                if (el.numero > inicio.numero)
                {
                    return (maiorFim(fim, el.proximo, cont + 1));
                }
                else
                {
                    return (maiorFim(fim, el.proximo, cont));
                }
            }
        }
        public int maiorFim()
        {
            Elemento aux = inicio;
            int cont = 0;
            while (aux != null)
            {
                if (aux.numero > fim.numero)
                {
                    cont++;
                }
                aux = aux.proximo;
            }
            return cont;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
