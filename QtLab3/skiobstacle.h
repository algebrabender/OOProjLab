#ifndef SKIOBSTACLE_H
#define SKIOBSTACLE_H

#include <QObject>
#include <QImage>

class SkiObstacle : public QObject
{
    Q_OBJECT
public:
    explicit SkiObstacle(QObject *parent = nullptr);
    QImage preprekaIMG;
    int x;
    int y;
    int w;
    int h;
};

#endif // SKIOBSTACLE_H
