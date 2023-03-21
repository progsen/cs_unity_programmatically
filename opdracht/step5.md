## de hoek om

ok de enemy beweegt maar stopt niet 


## richting berekenen

ga naar de regel ` RelAdd[] pathplus = new RelAdd[10];` in `GameEngine.cs`

daar maken we nu van:
```
RelAdd[] pathplus = new RelAdd[] {

            new RelAdd() {x=0,z=0 },
            new RelAdd() {x=0,z=1 },
            new RelAdd() {x=1,z=0},
            new RelAdd() {x=1,z=0},
            new RelAdd() {x=1,z=0},
            new RelAdd() {x=0,z=-1 },
            new RelAdd() {x=0,z=-1 },
            new RelAdd() {x=0,z=-1 },
            new RelAdd() {x=1,z=0},
            new RelAdd() {x=1,z=0},
            new RelAdd() {x=1,z=0},
        };
```

dit beschrijf het pad ten opzichten van de vorige tegel

## het pad anders aanmaken

1) in `  void Start()` maken we nu 3 lokale `int` variabelen aan:
- `int x = 0;`
- `int z = 0;`
- `int size = 2;`

Dit worden de coordinaten van een `tile`
En die passen we aan per stap van de `for loop`
De `size` is voor de grote per stap de modellen zijn `2` groot


2) vervang 
- `path[i] = Instantiate(tileModel, new Vector3(i * 2, 0, 0), Quaternion.identity);` 
met 
- `path[i] = Instantiate(tileModel, new Vector3(x, 0, z), Quaternion.identity);`

zie je hoe we nu de `x` en `z` gebruiken?


## x en z berekenen

in de for loop gaan we nu naar de `RelAdd` in `pathplus` kijken

1) haal voor de huidige `index` `i` de `RelAdd` op

```

            RelAdd step = ???;
```


2) gebruik nu de `x` en `z` data in `step` om de `x` en `z` in `Start` aan te passen:
```
            x += ???.x * size;
            z += ??? * size;
```

## testen


nu krijg je als het goed is te zien dat je een nieuw pad hebt:


![step5result.PNG](img/step5result.PNG)

maar de enemy loopt er niet op!

## Woops hij loopt verder


daar waren we nog wat vergeten

We kijken nog niet of de `Enemy` bij de `to` is gekomen

laten we dat nu gaan doen:

1) ga naar de `MoveEnemy` function

2) gebruik nu de `GetDist` function om de afstand tussen `enemy.obj` en `to` te berekenen:
```
        double dist = ???;
        Debug.Log(dist);
```

3) Als dat werkt kan je testen of `enemy` er bijna is:

```
        if (dist <= 0.01)
        {
                Debug.Log("goto next!");
        }
```
4) nu moeten we nog naar de volgende `from` en `to` van enemy
gebruik `++` hiervoor

5) 
voor de netheid zetten we de `enemy` ook even op de `to` waar hij bijna was:

`enemy.obj.transform.position = to.transform.position;`

doe dit in de `if`

## testen


nu krijg je als het goed is te zien dat je een nieuw pad hebt:


![step6result.PNG](img/step6result.PNG)

maar de enemy loopt er niet op!