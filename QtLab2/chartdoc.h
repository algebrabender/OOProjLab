#ifndef CHARTDOC_H
#define CHARTDOC_H

#include <QObject>
#include <QFile>
#include <QTextStream>
#include "chartpoint.h"

class ChartDoc : public QObject
{
    Q_OBJECT
public:
    explicit ChartDoc(QObject *parent = nullptr);

    QList<ChartPoint*> podaci; //idk kako struktura
    void loadChartFromFile(QString file);
    void saveChartToFile(QString file);

signals:
    void chartDataChanged();

};

#endif // CHARTDOC_H
