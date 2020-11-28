#ifndef SKISANTA_H
#define SKISANTA_H

#include <QObject>
#include <QImage>

class SkiSanta : public QObject
{
    Q_OBJECT
public:
    explicit SkiSanta(QObject *parent = nullptr);
    QImage santa1;
    QImage santa2;
    QImage santaleft1;
    QImage santaleft2;
    QImage santaright1;
    QImage santaright2;
    int x;
    int y;
    int w;
    int h;
    int trenutnoStanje; //-1-levo, 0-levo, 1-desno
};

#endif // SKISANTA_H
