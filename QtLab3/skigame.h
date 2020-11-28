#ifndef SKIGAME_H
#define SKIGAME_H

#include <QObject>
#include "skiobstacle.h"
#include "skisanta.h"
#include <QPainter>

class SkiGame : public QObject
{
    Q_OBJECT
public:
    explicit SkiGame(QObject *parent = nullptr);
    QList<SkiObstacle*> prepreke;
    SkiSanta* santa;
    QImage draw();
    void moveSanta(int dx);
    void tick();
    QImage santaIMG;
};

#endif // SKIGAME_H
