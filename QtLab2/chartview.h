#ifndef CHARTVIEW_H
#define CHARTVIEW_H

#include <QWidget>
#include <QMouseEvent>
#include "chartdoc.h"
#include "chartpointdialog.h"
#include <QPainter>


class ChartView : public QWidget
{
    Q_OBJECT
public:
    explicit ChartView(QWidget *parent = nullptr);
    void referenciranje(ChartDoc* referenca);
    void mouseDoubleClickEvent(QMouseEvent* event);

signals:

public slots:
    void onChartDataChanged();

public:
    ChartDoc* ref;

protected:
    void paintEvent(QPaintEvent*);
};

#endif // CHARTVIEW_H
