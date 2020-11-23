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
    QPainter painter(this);
    for (int j = 0; j < 10; j++)
    {
        painter.drawLine(30, 30+j*20, 45, 30+j*20);
    }
    painter.drawText(10, 35, "100");
    painter.drawText(10, 55, "90");
    painter.drawText(10, 75, "80");
    painter.drawText(10, 95, "70");
    painter.drawText(10, 115, "60");
    painter.drawText(10, 135, "50");
    painter.drawText(10, 155, "40");
    painter.drawText(10, 175, "30");
    painter.drawText(10, 195, "20");
    painter.drawText(10, 215, "10");
    painter.drawText(10, 235, "0");
    painter.drawLine(45, 30, 45, 230); //y osa
    painter.drawLine(30, 230, 1000, 230); //x osa
    for (int i = 0; i < ref->m_points.length(); i++)
    {
        //painter.setBrush(ref->m_points[i]->color);
        //painter.drawRect(45 + (100*i), 230, 70, -ref->m_points[i]->value*2);
        painter.drawText((100*i) + 65, 245, ref->m_points[i]->label);
    }

    for (int i = 0; i < ref->m_points.length(); i++)
    {
        drawSingleBar(80 + (100*i), ref->m_points[i]->value, ref->m_points[i]->color);
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
            for (int i = 0; i < ref->m_points.length(); i++)
            {
                if (x >= 45+100*i && x <= 115+100*i)
                {
                    ref->m_points[i]->label = CPDialog.getLabel();
                    ref->m_points[i]->value = CPDialog.getValue();
                    ref->m_points[i]->color = CPDialog.getColor();
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

void ChartView::drawSingleBar(int w, int h, QColor color)
{
    QPainter p(this);
    QPen olovkaZaOkvir; //olovka koja ce iscrtavati okvir
    QPen stub; //olovka koja ce iscrtavati stub
    QColor okvir; //boja za okvir treba biti crna
    okvir.setNamedColor("#000000");
    olovkaZaOkvir.setWidth(70); //okvir je sirine koliko stub treba da zauzme
    olovkaZaOkvir.setColor(okvir);
    stub.setWidth(68); //stub mora biti sa svih strana mora biti 1px manji da bi "stao" u okvir tj da bi okvir bio debljine 1px, tako da width mora biti za 2px manji
    stub.setColor(color); //boja stuba bice prosledjena kao parametar
    int start = 264 - h*2; //odredjivanje odakle treba da krene stub tj koliko je od 0-100
    //264 je "korekcija" da bi se podaci podudarali sa prethono iscrtanom osom zbog width-a olovke
    p.setPen(olovkaZaOkvir); //prvo se iscrtava okvir
    p.drawLine(w, start, w, 196); //iscrtavanje okvira krece od prosledjene sirine, da bi se pravio jednak razmak izmedju stubova
                                  //196 je "kraj" stuba, tj tu pocinje x osa
    p.setPen(stub); //iskrtavanje stuba unutar okvira cime se dobija efekat pravouganika bez zaobljenih ivica
    p.drawLine(w, start, w, 196); //nema potrebe menjati parametre za iscrtavanje "stuba" tj linije jer je podesena width
}
