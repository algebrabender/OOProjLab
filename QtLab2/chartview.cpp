#include "chartview.h"

ChartView::ChartView(QWidget *parent) : QWidget(parent)
{
    //ref = new ChartDoc();
}

void ChartView::referenciranje(ChartDoc* referenca)
{
    ref = referenca;
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
    p.drawLine(30, 230, 1000, 230); //x osa
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
            int x = event->x();
            //int y = event->y();
            for (int i = 0; i < ref->podaci.length(); i++)
            {
                if (x >= 45+100*i && x <= 115+100*i)
                {
                    ref->podaci[i]->label = CPDialog.getLabel();
                    ref->podaci[i]->value = CPDialog.getValue();
                    ref->podaci[i]->color = CPDialog.getColor();
                }
            }
            onChartDataChanged();
            emit ref->chartDataChanged();
        }
    }
}

void ChartView::onChartDataChanged()
{
    repaint(); //iscrtavanje grafika
}
