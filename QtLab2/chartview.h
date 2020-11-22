#ifndef CHARTVIEW_H
#define CHARTVIEW_H

#include <QWidget>
#include <QMouseEvent>
#include <QPainter>
#include "chartdoc.h"
#include "chartpointdialog.h"

class ChartView : public QWidget
{
    Q_OBJECT
public:
    explicit ChartView(QWidget *parent = nullptr);

    void mouseDoubleClickEvent(QMouseEvent* event);

signals:

public slots:
    void onChartDataChanged();

public:
    ChartDoc* ref; //not how it should be
protected:
    void paintEvent(QPaintEvent*);
};

#endif // CHARTVIEW_H
