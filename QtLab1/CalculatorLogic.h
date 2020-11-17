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
    bool jednakoPoslednje;
    double vrednost;
    double zaOperacije;
    QString rezultat;
    QString zaIstoriju;
    QString istorija;

    void doCommand(QString btn);

    signals:
    void resultChanged(QString);
    void resultHistoryChanged(QString);
};

#endif // CALCULATORLOGIC_H
