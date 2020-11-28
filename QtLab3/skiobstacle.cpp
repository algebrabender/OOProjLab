#include "skiobstacle.h"

SkiObstacle::SkiObstacle(QObject *parent) : QObject(parent)
{
    int type = qrand() % 2;
    //jelka 0/snesko 1
    if (!type)
        preprekaIMG.load(":/new/obstacles/IMAGES/tree.png");
    else
        preprekaIMG.load(":/new/obstacles/IMAGES/snowman.png");

    w = preprekaIMG.width();
    h = preprekaIMG.height();

    x = qrand() % 400; //prozor ce biti ogranicen na 450x400 max
    y = 400 + qrand() % 400;
}
