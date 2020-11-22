#include "chartdoc.h"

ChartDoc::ChartDoc(QObject *parent) : QObject(parent),  podaci(QList<ChartPoint*> ())
{

}
void ChartDoc::loadChartFromFile(QString file)
{
    QFile f(file);
    if(f.open(QIODevice::ReadOnly | QIODevice::Text))
    {
        QTextStream izFajla(&f);
        while (!izFajla.atEnd()) //citanje red po red
        {
            QString line = izFajla.readLine();
            QStringList parts = line.split(",");
            ChartPoint* stub = new ChartPoint;
            stub->label = parts[0];
            stub->value = parts[1].toFloat();
            stub->color.setNamedColor(parts[2]);
            podaci.append(stub);
        }
        f.close();
        emit chartDataChanged();
    }
    else // doslo je do greske pri otvaranju fajl
        return;
}

void ChartDoc::saveChartToFile(QString file)
{
    QFile f(file);
    if (f.open(QIODevice::WriteOnly | QIODevice::Text))
    {
        QTextStream uFajl(&f);
        for (int i = 0; i < podaci.length(); i++)
        {
            uFajl << podaci[i]->label << "," << podaci[i]->value << "," << podaci[i]->color.name() << "\n";
        }
        f.close();
    }
    else // doslo je do greske pri otvaranju fajl
        return;
}
