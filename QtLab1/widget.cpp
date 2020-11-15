#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent)
    : QWidget(parent)
    , ui(new Ui::Widget),
    calculatorLogic(new CalculatorLogic(this))
{
    ui->setupUi(this);
    ui->displayRezultata->setText(QString::number(calculatorLogic->trenutnaVrednost));
    connect(ui->button0, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button1, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button2, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button3, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button4, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button5, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button6, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button7, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button8, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->button9, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->plus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->minus, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->puta, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->podeljeno, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->jednako, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->koren, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->promenaZnaka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->clear, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->tacka, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(ui->backspace, SIGNAL(clicked()), this, SLOT(onBtnClicked()));
    connect(calculatorLogic, SIGNAL(resultChanged(QString)), this, SLOT(onResultChanged()));
    connect(calculatorLogic, SIGNAL(resultHistoryChanged(QString)), this, SLOT(onResultHistoryChanged()));
    sabiranje = oduzimanje = mnozenje = deljenje = false;
}

Widget::~Widget()
{
    delete ui;
}

void Widget::onBtnClicked()
{
    QPushButton* button = (QPushButton *)sender();
    calculatorLogic->doCommand(button->text());
}

void Widget::onResultChanged()
{
    if (!calculatorLogic->sabiranje && !calculatorLogic->oduzimanje && !calculatorLogic->mnozenje && !calculatorLogic->deljenje
            && !calculatorLogic->jednako && !calculatorLogic->korenovanje && !calculatorLogic->brisanje
            && !calculatorLogic->brisanjeCifre && !calculatorLogic->promenaZnaka && !calculatorLogic->tacka)
    {
        QString vrednost = QString::number(calculatorLogic->trenutnaVrednost);
        QString displejVrednost = ui->displayRezultata->text();
        if (displejVrednost.toDouble() == 0 || displejVrednost.toDouble() == 0.0)
        {
            rezultat = displejVrednost;
            ui->displayRezultata->setText(vrednost);
        }
        else
        {
            QString novaVrednost = displejVrednost + vrednost; //nadovezivanje cifara
            calculatorLogic->trenutnaVrednost = novaVrednost.toDouble();
            rezultat = novaVrednost;
            ui->displayRezultata->setText(novaVrednost);
        }

    }
    else if (calculatorLogic->sabiranje || calculatorLogic->oduzimanje || calculatorLogic->mnozenje || calculatorLogic->deljenje)
    {
        if (calculatorLogic->sabiranje)
        {
            rezultat = QString::number(calculatorLogic->trenutnaVrednost);
            zaIstoriju = rezultat + " + ";
            calculatorLogic->sabiranje = false;
            sabiranje = true;
        }
        else if (calculatorLogic->oduzimanje)
        {
            rezultat = QString::number(calculatorLogic->trenutnaVrednost);
            zaIstoriju = rezultat + " - ";
            calculatorLogic->oduzimanje = false;
            oduzimanje = true;
        }
        else if (calculatorLogic->mnozenje)
        {
            rezultat = QString::number(calculatorLogic->trenutnaVrednost);
            zaIstoriju = rezultat + " * ";
            calculatorLogic->mnozenje = false;
            mnozenje = true;
        }
        else
        {
            rezultat = QString::number(calculatorLogic->trenutnaVrednost);
            zaIstoriju = rezultat + " / ";
            calculatorLogic->deljenje = false;
            deljenje = true;
        }
        rezultat = ui->displayRezultata->text();
        rezultatVrednost = ui->displayRezultata->text().toDouble();
        ui->displayRezultata->setText("");
    }
    else if (calculatorLogic->jednako)
    {
        zaIstoriju += QString::number(calculatorLogic->trenutnaVrednost);
        if (sabiranje)
        {
            sabiranje = false;
            calculatorLogic->jednako = false;
            zaIstoriju += " = ";
            double novaVred = rezultatVrednost + calculatorLogic->trenutnaVrednost;
            rezultat = QString::number(novaVred);
            calculatorLogic->trenutnaVrednost = novaVred;
            zaIstoriju += QString::number(novaVred);
            ui->displayRezultata->setText(QString::number(novaVred));
        }
        else if (oduzimanje)
        {
            oduzimanje = false;
            calculatorLogic->jednako = false;
            zaIstoriju += " = ";
            double novaVred = rezultatVrednost - calculatorLogic->trenutnaVrednost;
            rezultat = QString::number(novaVred);
            calculatorLogic->trenutnaVrednost = novaVred;
            zaIstoriju += QString::number(novaVred);
            ui->displayRezultata->setText(QString::number(novaVred));
        }
        else if (mnozenje)
        {
            mnozenje = false;
            calculatorLogic->jednako = false;
            zaIstoriju += " = ";
            double novaVred = rezultatVrednost * calculatorLogic->trenutnaVrednost;
            rezultat = QString::number(novaVred);
            calculatorLogic->trenutnaVrednost = novaVred;
            zaIstoriju += QString::number(novaVred);
            ui->displayRezultata->setText(QString::number(novaVred));
        }
        else if (deljenje)
        {
            deljenje = false;
            calculatorLogic->jednako = false;
            zaIstoriju += " = ";
            if (calculatorLogic->trenutnaVrednost != 0 || calculatorLogic->trenutnaVrednost != 0.0)
            {
                double novaVred = rezultatVrednost / calculatorLogic->trenutnaVrednost;
                rezultat = QString::number(novaVred);
                calculatorLogic->trenutnaVrednost = novaVred;
                zaIstoriju += QString::number(novaVred);
                ui->displayRezultata->setText(QString::number(novaVred));
            }
            else
            {
                rezultat = "nan";
                zaIstoriju += rezultat;
                ui->displayRezultata->setText(rezultat);
            }
        }
    }
    else if (calculatorLogic->korenovanje)
    {
       calculatorLogic->korenovanje = false;
       zaIstoriju = "√" + QString::number(calculatorLogic->trenutnaVrednost);
       double novaVred = qSqrt(calculatorLogic->trenutnaVrednost);
       calculatorLogic->trenutnaVrednost = novaVred;
       rezultat = QString::number(calculatorLogic->trenutnaVrednost);
       zaIstoriju += " = " + QString::number(novaVred);
       ui->displayRezultata->setText(QString::number(novaVred));
    }
    else if (calculatorLogic->promenaZnaka)
    {
        calculatorLogic->promenaZnaka = false;
        double novaVred = (-1)* calculatorLogic->trenutnaVrednost;
        calculatorLogic->trenutnaVrednost = novaVred;
        rezultat = QString::number(calculatorLogic->trenutnaVrednost);
        zaIstoriju = "±" + QString::number(novaVred);
        ui->displayRezultata->setText(QString::number(novaVred));
    }
    else if (calculatorLogic->brisanje)
    {
        calculatorLogic->brisanje = false;
        calculatorLogic->trenutnaVrednost = 0.0;
        rezultat = QString::number(calculatorLogic->trenutnaVrednost);
        ui->displayRezultata->setText(QString::number(calculatorLogic->trenutnaVrednost));
    }
    else if (calculatorLogic->brisanjeCifre)
    {
        calculatorLogic->brisanjeCifre = false;
        QString displejVrednost = ui->displayRezultata->text();
        if (displejVrednost.toDouble() != 0 || displejVrednost.toDouble() != 0.0)
        {
            QString novaVred = ui->displayRezultata->text();
            novaVred.chop(1);
            calculatorLogic->trenutnaVrednost = novaVred.toDouble();
            rezultat = novaVred;
            ui->displayRezultata->setText(rezultat);
        }
    }
    else
    {
        calculatorLogic->tacka = false;
        QString novaVred = ui->displayRezultata->text()+".";
        calculatorLogic->trenutnaVrednost = novaVred.toDouble();
        rezultat = novaVred;
        ui->displayRezultata->setText(rezultat);
    }
}

void Widget::onResultHistoryChanged()
{
   istorija += zaIstoriju + "\n";
   ui->istorija->setPlainText(istorija);
}
