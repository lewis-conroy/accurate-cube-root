# accurate-cube-root
An algorithm I wrote to determine the cube root of a given input

Accurate for values in the order of trillions (tested with python only).

```py
def cube_root(y):
    x = 1  # output (the cube root of y)
    delta_x = y

    while  delta_x > -x*x:
        x = (2*x + (y / x**2)) / 3
        delta_x -= x
        
    return x
```
```cs
class Program {
    static float cubeRoot(y) {
        float x = 1;
        float delta = y;

        while (delta > -x*x) {
            x = (2*x + (y / x**2)) / 3;
        }

        return x;
    }
}
```
```js
function cubeRoot(y) {
    let x = 1;
    let delta = y;

    while (delta > -x*x) {
        x = (2*x + (y / x**2)) / 3;
        delta -= x;
    }

    return x;
}
```
