#include "skisanta.h"

SkiSanta::SkiSanta(QObject *parent) : QObject(parent)
{
    santa1.load(":/new/santa/IMAGES/santa1.png");
    santa2.load(":/new/santa/IMAGES/santa2.png");
    santaleft1.load(":/new/santa/IMAGES/santa-left1.png");
    santaleft2.load(":/new/santa/IMAGES/santa-left2.png");
    santaright1.load(":/new/santa/IMAGES/santa-right1.png");
    santaright2.load(":/new/santa/IMAGES/santa-right2.png");

    trenutnoStanje = 0;
    w = santa1.width();
    h = santa1.height();
    x = 0;
    y = 150;

    animacija = 1;
}
