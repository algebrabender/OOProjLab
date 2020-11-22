#include "chartview.h"
#include <QMessageBox>

ChartView::ChartView(QWidget *parent) : QWidget(parent)
{
    ref = new ChartDoc();
    ChartPoint* point = new ChartPoint();
    point->label = "dva";
    point->value = 60;
    point->color.setNamedColor("#000000");
    ref->podaci.append(point);
    ChartPoint* point2 = new ChartPoint();
    point2->label = "tri";
    point2->value = 10;
    point2->color.setNamedColor("#000fd0");
    ref->podaci.append(point2);
}

void ChartView::paintEvent(QPaintEvent*)
{
    QPainter p(this);
    for (int j = 0; j < 10; j++)
    {
        p.drawLine(30, 30+j*20, 45, 30+j*20);
    }
    p.drawText(10, 35, "100");
    p.drawText(10, 55, "90");
    p.drawText(10, 75, "80");
    p.drawText(10, 95, "70");
    p.drawText(10, 115, "60");
    p.drawText(10, 135, "50");
    p.drawText(10, 155, "40");
    p.drawText(10, 175, "30");
    p.drawText(10, 195, "20");
    p.drawText(10, 215, "10");
    p.drawText(10, 235, "0");
    p.drawLine(45, 30, 45, 230); //y osa
    p.drawLine(30, 230, 620, 230); //x osa
    for (int i = 0; i < ref->podaci.length(); i++)
    {
        p.setBrush(ref->podaci[i]->color);
        p.drawRect(45 + (100*i), 230, 70, height() - height() - (ref->podaci[i]->value*2));
        p.drawText((100*i) + 65, 250, ref->podaci[i]->label);
    }
}

void ChartView::mouseDoubleClickEvent(QMouseEvent* event)
{
    if(event->button() == Qt::LeftButton)
    {
        ChartPointDialog CPDialog;
        if (CPDialog.exec() == QDialog::Accepted) //ako je prtisnuto OK potrebno je izmeniti podatke
        {
            ChartPoint* stub = new ChartPoint();
            stub->label = CPDialog.getLabel();
            stub->value = CPDialog.getValue();
            stub->color = CPDialog.getColor();
            ref->podaci.append(stub);
            onChartDataChanged();
            //emit ref->chartDataChanged();
        }
    }
}

void ChartView::onChartDataChanged()
{
    repaint(); //iscrtavanje grafika
}
