#include "skigame.h"

SkiGame::SkiGame(QObject *parent) : QObject(parent)
{
    santa = new SkiSanta();
    santaIMG = santa->santa1;
    for (int i = 0; i < 15; i++)
        prepreke.append(new SkiObstacle());
}

void SkiGame::moveSanta(int dx)
{
    if (dx == 20)
    {
        santa->trenutnoStanje = 1;
        santa->x += dx;
        if (santa->x > 450-santa->w)
            santa->x = 450-santa->w;
    }
    else if (dx == -20)
    {
        santa->trenutnoStanje = -1;
        santa->x += dx;
        if (santa->x < 0)
            santa->x = 0;
    }
}

QImage SkiGame::draw()
{
    if (santa->trenutnoStanje == 1)
    {
        santa->trenutnoStanje = 0;
        if (santa->animacija == 1)
        {
            santa->animacija = 2;
            return santa->santaright1;
        }
        else
        {
            santa->animacija = 1;
            return santa->santaright2;
        }
    }
    else if (santa->trenutnoStanje == -1)
    {
        santa->trenutnoStanje = 0;
        if (santa->animacija == 1)
        {
            santa->animacija = 2;
            return santa->santaleft1;
        }
        else
        {
            santa->animacija = 1;
            return santa->santaleft2;
        }
    }
    else
    {
        if (santa->animacija == 1)
        {
            santa->animacija = 2;
            return santa->santa1;
        }
        else
        {
            santa->animacija = 1;
            return santa->santa2;
        }
    }
}

void SkiGame::tick()
{
    for (int i = 0; i < prepreke.length(); i++)
    {
        prepreke[i]->y -= 30;
        if (prepreke[i]->y < 0 - prepreke[i]->h)
        {
            prepreke[i]->y = 400 + qrand() % 400;
            prepreke[i]->x = qrand() % 400;
        }
    }
}
