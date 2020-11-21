#include "chartview.h"
#include <QMessageBox>

ChartView::ChartView(QWidget *parent) : QWidget(parent)
{
    ref = new ChartDoc();
    /*series = new QBarSeries();
    chart = new QChart();
    axisX = new QBarCategoryAxis();
    axisY = new QValueAxis();
    axisY->setRange(0,100);*/
}

void ChartView::paintEvent(QPaintEvent*)
{
    QPainter p(this);
    p.setPen("#ffffff");
    for (int i =0; i < ref->podaci.length(); i++)
    {
        p.setBrush(ref->podaci[i]->color);
        p.drawRect(10, 10, 100, ref->podaci[i]->value);
    }
}

void ChartView::mouseDoubleClickEvent(QMouseEvent* event)
{
    if(event->button() == Qt::LeftButton)
    {
        ChartPointDialog CPDialog;
        if (CPDialog.exec() == QDialog::Accepted) //ako je prtisnuto OK potrebno je izmeniti podatke
        {
            //emit ref->chartDataChanged();
            ChartPoint* stub = new ChartPoint();
            stub->label = CPDialog.getLabel();
            stub->value = CPDialog.getValue();
            stub->color = CPDialog.getColor();
            ref->podaci.append(stub);
            onChartDataChanged();
        }
    }
}

void ChartView::onChartDataChanged()
{
    /*for (int i =0; i < ref->podaci.length(); i++)
    {
        QString labela = ref->podaci[i]->label;
        QBarSet* stub = new QBarSet(labela);
        *stub << ref->podaci[i]->value;
        stub->setColor(ref->podaci[i]->color);
        stubovi.append(stub);
        labele.append(labela);
    }
    for(int i = 0; i < stubovi.length(); i++)
    {
        series->append(stubovi[i]);
    }
    chart->addSeries(series);
    chart->setAnimationOptions(QChart::SeriesAnimations);
    axisX->append(labele);
    chart->addAxis(axisX, Qt::AlignBottom);
    series->attachAxis(axisX);
    chart->addAxis(axisY, Qt::AlignLeft);
    series->attachAxis(axisY);
    chartView = new QChartView(chart);*/
    repaint();
}
