#ifndef CALCULATORLOGIC_H
#define CALCULATORLOGIC_H

#include <QObject>
#include <QtMath>

class CalculatorLogic : public QObject
{
    Q_OBJECT
public:
    explicit CalculatorLogic(QObject *parent = 0);
    double trenutnaVrednost;
    double vrednost;
    double zaOperacije;
    QString rezultat;
    QString zaIstoriju;
    bool sabiranje;
    bool oduzimanje;
    bool mnozenje;
    bool deljenje;
    bool jednako;
    bool promenaZnaka;
    bool brisanje;
    bool korenovanje;
    bool brisanjeCifre;
    bool tacka;
    bool sabZaJednako;
    bool oduZaJednako;
    bool mnoZaJednako;
    bool delZaJednako;

    void doCommand(QString btn);

    signals:
    void resultChanged(QString);
    void resultHistoryChanged(QString);
};

#endif // CALCULATORLOGIC_H
