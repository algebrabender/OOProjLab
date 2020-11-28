#ifndef SKIVIEW_H
#define SKIVIEW_H

#include <QWidget>
#include "skigame.h"
#include <QPainter>
#include <QKeyEvent>
#include <QTimer>

class SkiView : public QWidget
{
    Q_OBJECT
public:
    explicit SkiView(QWidget *parent = nullptr);
    QTimer* timer;
public slots:
    void tick();

private:
    SkiGame* game;
    void paintEvent(QPaintEvent* e);
    void keyPressEvent(QKeyEvent* e);
    QImage* santa;
};

#endif // SKIVIEW_H
