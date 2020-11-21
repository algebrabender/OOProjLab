#ifndef CHARTVIEW_H
#define CHARTVIEW_H

#include <QWidget>
#include <QMouseEvent>
#include "chartdoc.h"
#include "chartpointdialog.h"
/*#include <QtCharts/QBarSet>
#include <QtCharts/QBarSeries>
#include <QtCharts/QChartView>
#include <QtCharts/QBarCategoryAxis>
#include <QtCharts/QValueAxis>*/
#include <QPainter>

//QT_CHARTS_USE_NAMESPACE

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
    /*QList<QBarSet *> stubovi;
    QBarSeries *series;
    QChart *chart;
    QStringList labele;
    QBarCategoryAxis *axisX;
    QValueAxis *axisY;
    QChartView *chartView;*/
protected:
    void paintEvent(QPaintEvent*);
};

#endif // CHARTVIEW_H
