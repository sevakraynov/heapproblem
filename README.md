# Задача о камнях

Пусть имеется ![](https://latex.codecogs.com/gif.latex?n) камней с весами ![](https://latex.codecogs.com/gif.latex?v_1,...,v_n,&space;j&space;=&space;\overline{1,&space;n}). Необходимо разложить их на ![](https://latex.codecogs.com/gif.latex?m) куч так, чтобы вес самой тяжелой кучи был минимальным.

Пусть ![](https://latex.codecogs.com/gif.latex?N_i) – множество, элементы которого являются номерами камней, содержащихся в куче ![](https://latex.codecogs.com/gif.latex?i):

![](https://latex.codecogs.com/gif.latex?N_i&space;\subset&space;1..n,&space;\:&space;i&space;=&space;\overline{1,&space;m})

![](https://latex.codecogs.com/gif.latex?N_i&space;\cap&space;N_k&space;=&space;\varnothing,&space;\:&space;i&space;\neq&space;k)

Для удобства введем переменную ![](https://latex.codecogs.com/gif.latex?x_j) – номер кучи, в которую помещен камень ![](https://latex.codecogs.com/gif.latex?j).

Для решения задачи нужно найти минимум функции:

![](https://latex.codecogs.com/gif.latex?\max_{i=1,...,m}&space;\begin{Bmatrix}&space;\sum_{j&space;\in&space;N}&space;v_j&space;\end{Bmatrix}&space;\rightarrow&space;\min)

# Решение задачи

Предлагается следующий жадный алгоритм. На каждом шаге будем брать самый тяжелый камень из оставшихся и класть его в самую легкую кучу. Пусть камни упорядочены по убыванию весов:

![](https://latex.codecogs.com/gif.latex?v_1&space;\geq&space;v_2&space;\geq&space;...&space;\geq&space;v_n).

Обозначим через ![](https://latex.codecogs.com/gif.latex?b_i) – вес кучи ![](https://latex.codecogs.com/gif.latex?i,&space;i&space;=&space;\overline{1,&space;m}). Псевдокод алгоритма имеет следующий вид:

```
for i = 1 to m do
 b_i = 0
for j = 1 to n do
  k = argmin(bi) # i = 1,...,m
  x_j = k
  b_k = b_k + v_j
```

---
[Источник](https://petrsu.ru/files/document/uploads/algol.pdf)
