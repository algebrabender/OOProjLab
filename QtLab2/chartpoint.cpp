#include "chartpoint.h"

ChartPoint::ChartPoint(QObject *parent) : QObject(parent)
{
    label = "";
    value = 0.0;
    color.setNamedColor("#000000");
}
