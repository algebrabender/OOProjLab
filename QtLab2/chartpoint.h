#ifndef CHARTPOINT_H
#define CHARTPOINT_H

#include <QObject>
#include <QColor>

class ChartPoint : public QObject
{
    Q_OBJECT
public:
    explicit ChartPoint(QObject *parent = nullptr);

    QString label;
    float value;
    QColor color;
};

#endif // CHARTPOINT_H
