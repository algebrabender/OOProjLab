#include "skiview.h"

SkiView::SkiView(QWidget *parent) : QWidget(parent)
{
    setFocusPolicy(Qt::StrongFocus);
    game = new SkiGame();
    timer = new QTimer(this);
    timer->start(1000);
    connect(timer, SIGNAL(timeout()), this, SLOT(tick()));
}

void SkiView::paintEvent(QPaintEvent*)
{
    QPainter p(this);
    p.drawImage(game->santa->x, game->santa->y, game->draw());
    for (int i = 0; i < game->prepreke.length(); i++)
        p.drawImage(game->prepreke[i]->x, game->prepreke[i]->y, game->prepreke[i]->preprekaIMG);
}


void SkiView::keyPressEvent(QKeyEvent* e)
{
    switch (e->key())
    {
    case Qt::Key_Right:
        game->moveSanta(20);
        break;
    case Qt::Key_Left:
        game->moveSanta(-20);
        break;
    default:
        QWidget::keyPressEvent(e);
    }
    repaint();
}

void SkiView::tick()
{
    game->tick();
    repaint();
}
